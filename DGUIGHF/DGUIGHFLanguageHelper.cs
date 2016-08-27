#region License
// Copyright (c) 2014 Davide Gironi
//
// Please refer to LICENSE file for licensing information.
#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Web.Script.Serialization;

namespace DG.UI.GHF
{
    public class DGUIGHFLanguageHelper
    {
        /// <summary>
        /// Default language filename
        /// </summary>
        public static string DefaultLanguageFilename = "language.json";

        /// <summary>
        /// Get or Set caller of this class
        /// </summary>
        protected internal object _sender = null;

        /// <summary>
        /// Loaded default text
        /// </summary>
        private IDictionary<string, string> _defaulttext = new Dictionary<string, string>() { };

        /// <summary>
        /// Loaded additional text
        /// </summary>
        private IDictionary<string, string> _additionaltext = new Dictionary<string, string>() { };

        /// <summary>
        /// Registered components
        /// </summary>
        private IList<LangComponents> _langcomponents = new List<LangComponents>();

        /// <summary>
        /// Lang components
        /// </summary>
        private struct LangComponents
        {
            public string controlName;
            public string defaultValue;
            public string value;
            public object control;
            public string groupName;
            public string valueProperty;
            public string nameProperty;
            public string languageKey;
            public PropertyInfo propertyInfoValue;
        }

        /// <summary>
        /// Language constructor
        /// </summary>
        /// <param name="sender"></param>
        public DGUIGHFLanguageHelper(object sender)
        {
            this._sender = sender;
        }

        /// <summary>
        /// Get all language text
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, string> Get()
        {
            IDictionary<string, string> ret = new Dictionary<string, string>() { };

            //add base text
            IDictionary<string, string> defaulttext = new Dictionary<string, string>() { };
            DGUIGHFLanguageBase dguightlanguagedefault = (DGUIGHFLanguageBase)Activator.CreateInstance(typeof(DGUIGHFLanguageBase));
            foreach (FieldInfo field in dguightlanguagedefault.GetType().GetFields())
            {
                if (field.FieldType == typeof(string))
                {
                    string key = field.Name;
                    string value = field.GetValue(dguightlanguagedefault).ToString();
                    if (!defaulttext.ContainsKey(key))
                        defaulttext.Add(key, value);
                    if (!ret.ContainsKey("Form-" + key))
                    {
                        if (_defaulttext.ContainsKey(key))
                            ret.Add("Form-" + key, _defaulttext[key]);
                        else
                            ret.Add("Form-" + key, value);
                    }
                }
            }

            //add components text
            foreach (LangComponents langcomponent in _langcomponents)
            {
                string key = langcomponent.languageKey;
                string value = langcomponent.value;

                if (!ret.ContainsKey(key))
                    ret.Add(key, value);
            }

            //add additional language text
            foreach (KeyValuePair<string, string> entry in _additionaltext)
            {
                if (!ret.ContainsKey(entry.Key))
                    ret.Add(entry.Key, entry.Value);
            }

            //add form text
            foreach (FieldInfo genericdformlanguage in _sender.GetType().GetFields())
            {
                object genericformlanguageinstance = genericdformlanguage.GetValue(_sender);
                if (genericformlanguageinstance.GetType().GetInterfaces().Contains(typeof(IDGUIGHFLanguage)))
                {
                    foreach (FieldInfo field in genericformlanguageinstance.GetType().GetFields())
                    {
                        if (field.FieldType == typeof(string))
                        {
                            string key = field.Name;
                            string value = field.GetValue(genericformlanguageinstance).ToString();

                            bool addorupdate = false;

                            if (!defaulttext.ContainsKey(key))
                            {
                                addorupdate = true;
                            }
                            else
                            {
                                if (_defaulttext.ContainsKey(key))
                                {
                                    if (value != defaulttext[key] && value != _defaulttext[key])
                                    {
                                        addorupdate = true;
                                    }
                                }
                                else
                                {
                                    if (value != defaulttext[key])
                                    {
                                        addorupdate = true;
                                    }
                                }
                            }

                            if (addorupdate)
                            {
                                string keyprefix = "Text-";
                                if (_sender.GetType().IsSubclassOf(typeof(DGUIGHFForm)) ||
                                    _sender.GetType().IsSubclassOf(typeof(DGUIGHFFormMain)))
                                    keyprefix = "Form-";

                                if (!ret.ContainsKey(_sender.GetType().Name + "-" + key))
                                    ret.Add(keyprefix + _sender.GetType().Name + "-" + key, value);
                                else
                                    ret[keyprefix + _sender.GetType().Name + "-" + key] = value;
                            }
                        }
                    }
                }
            }

            return ret;
        }

        /// <summary>
        /// Set all language text
        /// </summary>
        /// <param name="language"></param>
        /// <returns></returns>
        public bool Load(IDictionary<string, string> language)
        {
            bool ret = true;

            //add base text
            IDictionary<string, string> defaulttext = new Dictionary<string, string>() { };
            DGUIGHFLanguageBase dguightlanguagedefault = (DGUIGHFLanguageBase)Activator.CreateInstance(typeof(DGUIGHFLanguageBase));
            foreach (FieldInfo field in dguightlanguagedefault.GetType().GetFields())
            {
                if (field.FieldType == typeof(string))
                {
                    string key = field.Name;
                    string value = field.GetValue(dguightlanguagedefault).ToString();
                    if (!defaulttext.ContainsKey(key))
                        defaulttext.Add(key, value);
                    if (!_defaulttext.ContainsKey(key))
                        _defaulttext.Add(key, value);
                }
            }

            //set form text
            foreach (FieldInfo genericformlanguage in _sender.GetType().GetFields())
            {
                object genericformlanguageinstance = genericformlanguage.GetValue(_sender);
                if (genericformlanguageinstance.GetType().GetInterfaces().Contains(typeof(IDGUIGHFLanguage)))
                {
                    foreach (FieldInfo field in genericformlanguageinstance.GetType().GetFields())
                    {
                        if (field.FieldType == typeof(string))
                        {
                            string key = field.Name;
                            string value = field.GetValue(genericformlanguageinstance).ToString();

                            string keyprefix = "Text-";
                            if (_sender.GetType().IsSubclassOf(typeof(DGUIGHFForm)) ||
                                _sender.GetType().IsSubclassOf(typeof(DGUIGHFFormMain)))
                                keyprefix = "Form-";

                            bool update = false;

                            if (!defaulttext.ContainsKey(key))
                            {
                                if (language.ContainsKey(keyprefix + _sender.GetType().Name + "-" + key))
                                {
                                    update = true;
                                    value = language[keyprefix + _sender.GetType().Name + "-" + key];
                                }
                            }
                            else
                            {
                                if (language.ContainsKey(keyprefix + _sender.GetType().Name + "-" + key))
                                {
                                    update = true;
                                    value = language[keyprefix + _sender.GetType().Name + "-" + key];
                                }
                                else if (language.ContainsKey(keyprefix + key))
                                {
                                    update = true;
                                    value = language[keyprefix + key];
                                    //override global language text
                                    if (_defaulttext.ContainsKey(key))
                                    {
                                        _defaulttext[key] = language[keyprefix + key];
                                    }
                                }
                            }

                            if (update)
                            {
                                field.SetValue(genericformlanguageinstance, value);
                            }
                        }
                    }
                }
            }

            //set components text
            for (int i = 0; i < _langcomponents.Count; i++)
            {
                LangComponents langcomponent = _langcomponents[i];
                if (language.ContainsKey(langcomponent.languageKey))
                {
                    langcomponent.value = language[langcomponent.languageKey];
                    try
                    {
                        //update component text
                        langcomponent.propertyInfoValue.SetValue(langcomponent.control, language[langcomponent.languageKey], null);
                        //update component in list
                        _langcomponents[i] = langcomponent;
                    }
                    catch { }
                }
            }

            return ret;
        }

        /// <summary>
        /// Add a component to the translation list
        /// </summary>
        /// <param name="control"></param>
        /// <param name="groupName"></param>
        /// <param name="valueProperty"></param>
        /// <param name="nameProperty"></param>
        public void AddComponent(object control, string groupName, string valueProperty, string nameProperty)
        {
            string textDefault = "";
            string textKey = "";
            string textName = "";

            if (!String.IsNullOrEmpty(groupName) && !String.IsNullOrEmpty(nameProperty) && !String.IsNullOrEmpty(valueProperty))
            {
                PropertyInfo propertyInfoKey = control.GetType().GetProperty(nameProperty);
                if (propertyInfoKey != null)
                {
                    textName = propertyInfoKey.GetValue(control).ToString();
                    textKey = "Form-" + groupName + "-" + textName;
                }
                if (!String.IsNullOrEmpty(textKey))
                {
                    PropertyInfo propertyInfoValue = control.GetType().GetProperty(valueProperty);
                    if (propertyInfoValue != null)
                    {
                        try
                        {
                            //get default text
                            textDefault = propertyInfoValue.GetValue(control).ToString();

                            //add component to list
                            if (_langcomponents.Where(r => r.controlName == textKey).Count() == 0)
                            {
                                _langcomponents.Add(new LangComponents()
                                {
                                    controlName = textName,
                                    defaultValue = textDefault,
                                    value = textDefault,
                                    control = control,
                                    groupName = groupName,
                                    nameProperty = nameProperty,
                                    valueProperty = valueProperty,
                                    languageKey = textKey,
                                    propertyInfoValue = propertyInfoValue
                                });
                            }

                        }
                        catch { }
                    }
                }
            }
        }

        /// <summary>
        /// Add a component to the translation list, use "Text" as valueProperty
        /// </summary>
        /// <param name="control"></param>
        /// <param name="groupName"></param>
        /// <param name="valueProperty"></param>
        public void AddComponent(object control, string groupName, string valueProperty)
        {
            AddComponent(control, groupName, valueProperty, "Name");
        }

        /// <summary>
        /// Add a component to the translation list, use "Text" as valueProperty and "Name" as nameProperty
        /// </summary>
        /// <param name="control"></param>
        /// <param name="groupName"></param>
        public void AddComponent(object control, string groupName)
        {
            AddComponent(control, groupName, "Text", "Name");
        }

        /// <summary>
        /// Add a component to the translation list, use declaring object name as groupName, "Text" as valueProperty and "Name" as nameProperty
        /// </summary>
        /// <param name="control"></param>
        public void AddComponent(object control)
        {
            string groupName = "";
            try
            {
                groupName = new StackFrame(1).GetMethod().DeclaringType.Name;
            }
            catch { }
            AddComponent(control, groupName);
        }

        /// <summary>
        /// Add additional text to current language
        /// </summary>
        /// <param name="control"></param>
        public void AddAdditionalLanguage(IDictionary<string, string> language)
        {
            foreach (KeyValuePair<string, string> entry in language)
            {
                if (!_additionaltext.ContainsKey(entry.Key))
                    _additionaltext.Add(entry.Key, entry.Value);
            }
        }

        /// <summary>
        /// Set all language text load from file
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public bool LoadFromFile(string filename)
        {
            bool ret = false;

            IDictionary<string, string> language = Get();

            if (!String.IsNullOrEmpty(filename))
            {
                //deserialize the file
                try
                {
                    string jsontext = File.ReadAllText(filename);
                    language = new JavaScriptSerializer().Deserialize<Dictionary<string, string>>(jsontext);
                    ret = true;
                }
                catch { }
            }

            if (ret)
                ret = Load(language);

            return ret;
        }

        /// <summary>
        /// Write all language text load to file
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public bool WriteToFile(string filename)
        {
            bool ret = false;

            IDictionary<string, string> language = Get();

            if (!String.IsNullOrEmpty(filename))
            {
                //serialize the list
                try
                {
                    string jsontext = new SimpleJsonFormatter(new JavaScriptSerializer().Serialize(language)).Format();
                    File.WriteAllText(filename, jsontext, Encoding.UTF8);
                    ret = true;
                }
                catch { }
            }

            return ret;
        }

        /// <summary>
        /// Rebuilt default language file
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static bool RebuiltDefaultLanguage(string filename)
        {
            bool ret = false;

            //get text from all classes
            IDictionary<string, string> defaultlanguage = GetAllLanguages();

            //write text to file
            if (!String.IsNullOrEmpty(filename))
            {
                //serialize the list
                try
                {
                    string jsontext = new SimpleJsonFormatter(new JavaScriptSerializer().Serialize(defaultlanguage)).Format();
                    File.WriteAllText(filename, jsontext, Encoding.UTF8);
                    ret = true;
                }
                catch { }
            }

            return ret;
        }

        /// <summary>
        /// Check a language file against default values
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="removeNotNeeded"></param>
        /// <param name="messages"></param>
        /// <returns></returns>
        public static bool RebuiltLanguage(string filename, bool removeNotNeeded, ref string[] messages)
        {
            bool ret = false;
            messages = new string[] { };

            IDictionary<string, string> rebuiltlanguage = new Dictionary<string, string>();

            //get text from all classes
            IDictionary<string, string> defaultlanguage = GetAllLanguages();

            //get text from language file
            IDictionary<string, string> loadedlanguage = new Dictionary<string, string>();
            //read text from file
            if (!String.IsNullOrEmpty(filename))
            {
                //deserialize the file
                try
                {
                    string jsontext = File.ReadAllText(filename);
                    loadedlanguage = new JavaScriptSerializer().Deserialize<Dictionary<string, string>>(jsontext);
                    ret = true;
                }
                catch { }
            }

            //check the languages
            foreach (KeyValuePair<string, string> entry in defaultlanguage)
            {
                //add the existing key
                if (loadedlanguage.ContainsKey(entry.Key))
                    rebuiltlanguage.Add(entry.Key, loadedlanguage[entry.Key]);
                //add not existing key
                else
                {
                    rebuiltlanguage.Add(entry.Key, defaultlanguage[entry.Key]);
                    messages = messages.Concat(new string[] { "Text \"" + entry.Key + "\" not found. Added using default value." }).ToArray();
                }
            }
            foreach (KeyValuePair<string, string> entry in loadedlanguage)
            {
                //remove not existing key
                if (!defaultlanguage.ContainsKey(entry.Key))
                {
                    if (removeNotNeeded)
                        messages = messages.Concat(new string[] { "Text \"" + entry.Key + "\" not needed. Removed." }).ToArray();
                    else
                    {
                        rebuiltlanguage.Add(entry.Key, loadedlanguage[entry.Key]);
                        messages = messages.Concat(new string[] { "Text \"" + entry.Key + "\" not needed. Not removed." }).ToArray();
                    }
                }
            }

            //write text to file
            if (!String.IsNullOrEmpty(filename))
            {
                //serialize the list
                try
                {
                    string jsontext = new SimpleJsonFormatter(new JavaScriptSerializer().Serialize(rebuiltlanguage)).Format();
                    File.WriteAllText(filename, jsontext, Encoding.UTF8);
                    ret = true;
                }
                catch { }
            }

            return ret;
        }

        /// <summary>
        /// Get all text from all classes with LanguageHelper
        /// </summary>
        /// <returns></returns>
        private static IDictionary<string, string> GetAllLanguages()
        {
            IDictionary<string, string> alltext = new Dictionary<string, string>() { };

            //instantiate all forms and get all languages
            Type[] types = Assembly.GetEntryAssembly().GetTypes().Where(r => r.IsClass).ToArray();
            foreach (Type type in types)
            {
                //unset language filename
                if (type.Name == "Program")
                {
                    foreach (FieldInfo uighfApplication in type.GetFields())
                    {
                        if (uighfApplication.FieldType == typeof(DGUIGHFApplication))
                        {
                            object uighfApplicationinstance = uighfApplication.GetValue(type);
                            PropertyInfo prop = uighfApplicationinstance.GetType().GetProperty("LanguageFilename");
                            prop.SetValue(uighfApplicationinstance, "");
                        }
                    }
                }
            }
            foreach (Type type in types)
            {
                if (type.GetMember("LanguageHelper").Count() > 0)
                {
                    try
                    {
                        //langauge is loaded at creation time
                        object classInstance = Activator.CreateInstance(type, null);
                        //get language values
                        PropertyInfo prop = classInstance.GetType().GetProperty("LanguageHelper");
                        MethodInfo getMethod = prop.PropertyType.GetMethod("Get");
                        IDictionary<string, string> languagevalues = (IDictionary<string, string>)getMethod.Invoke(prop.GetValue(classInstance, null), new object[] { });
                        foreach (KeyValuePair<string, string> entry in languagevalues)
                        {
                            if (!alltext.ContainsKey(entry.Key))
                                alltext.Add(entry.Key, entry.Value);
                        }
                    }
                    catch { }
                }
            }

            return alltext;
        }

        /// <summary>
        /// SimpleJsonFormatter
        /// http://www.limilabs.com/blog/json-net-formatter
        /// </summary>
        private class SimpleJsonFormatter
        {
            private readonly StringWalker _walker;
            private readonly IndentWriter _writer = new IndentWriter();
            private readonly StringBuilder _currentLine = new StringBuilder();
            private bool _quoted;

            public SimpleJsonFormatter(string json)
            {
                _walker = new StringWalker(json);
                ResetLine();
            }

            public void ResetLine()
            {
                _currentLine.Length = 0;
            }

            public string Format()
            {
                while (MoveNextChar())
                {
                    if (this._quoted == false && this.IsOpenBracket())
                    {
                        this.WriteCurrentLine();
                        this.AddCharToLine();
                        this.WriteCurrentLine();
                        _writer.Indent();
                    }
                    else if (this._quoted == false && this.IsCloseBracket())
                    {
                        this.WriteCurrentLine();
                        _writer.UnIndent();
                        this.AddCharToLine();
                    }
                    else if (this._quoted == false && this.IsColon())
                    {
                        this.AddCharToLine();
                        this.WriteCurrentLine();
                    }
                    else
                    {
                        AddCharToLine();
                    }
                }
                this.WriteCurrentLine();
                return _writer.ToString();
            }

            private bool MoveNextChar()
            {
                bool success = _walker.MoveNext();
                if (this.IsApostrophe())
                {
                    this._quoted = !_quoted;
                }
                return success;
            }

            public bool IsApostrophe()
            {
                return this._walker.CurrentChar == '"' && this._walker.IsEscaped == false;
            }

            public bool IsOpenBracket()
            {
                return this._walker.CurrentChar == '{'
                    || this._walker.CurrentChar == '[';
            }

            public bool IsCloseBracket()
            {
                return this._walker.CurrentChar == '}'
                    || this._walker.CurrentChar == ']';
            }

            public bool IsColon()
            {
                return this._walker.CurrentChar == ',';
            }

            private void AddCharToLine()
            {
                this._currentLine.Append(_walker.CurrentChar);
            }

            private void WriteCurrentLine()
            {
                string line = this._currentLine.ToString().Trim();
                if (line.Length > 0)
                {
                    _writer.WriteLine(line);
                }
                this.ResetLine();
            }

            public class StringWalker
            {
                private readonly string _s;

                public int Index { get; private set; }
                public bool IsEscaped { get; private set; }
                public char CurrentChar { get; private set; }

                public StringWalker(string s)
                {
                    _s = s;
                    this.Index = -1;
                }

                public bool MoveNext()
                {
                    if (this.Index == _s.Length - 1)
                        return false;

                    if (IsEscaped == false)
                        IsEscaped = CurrentChar == '\\';
                    else
                        IsEscaped = false;
                    this.Index++;
                    CurrentChar = _s[Index];
                    return true;
                }
            }

            public class IndentWriter
            {
                private readonly StringBuilder _result = new StringBuilder();
                private int _indentLevel;

                public void Indent()
                {
                    _indentLevel++;
                }

                public void UnIndent()
                {
                    if (_indentLevel > 0)
                        _indentLevel--;
                }

                public void WriteLine(string line)
                {
                    _result.AppendLine(CreateIndent() + line);
                }

                private string CreateIndent()
                {
                    StringBuilder indent = new StringBuilder();
                    for (int i = 0; i < _indentLevel; i++)
                        indent.Append("    ");
                    return indent.ToString();
                }

                public override string ToString()
                {
                    return _result.ToString();
                }
            }

        }

        /// <summary>
        /// Get a variable name
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="expr"></param>
        /// <returns></returns>
        private static string VariableName<T>(Expression<Func<T>> expr)
        {
            var body = ((MemberExpression)expr.Body);
            return body.Member.Name;
        }

        /// <summary>
        /// Get a variable value
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="expr"></param>
        /// <returns></returns>
        private static object VariableValue<T>(Expression<Func<T>> expr)
        {
            var body = ((MemberExpression)expr.Body);
            return ((FieldInfo)body.Member).GetValue(((ConstantExpression)body.Expression).Value);
        }
    }
}

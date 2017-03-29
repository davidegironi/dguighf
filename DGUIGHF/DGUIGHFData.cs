#region License
// Copyright (c) 2014 Davide Gironi
//
// Please refer to LICENSE file for licensing information.
#endregion

using DG.Data.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DG.UI.GHF
{

    public static class DGUIGHFData
    {
        /// <summary>
        /// Validate and Add a record
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="M"></typeparam>
        /// <param name="dataRepository"></param>
        /// <param name="item"></param>
        public static void Add<T, M>(GenericDataRepository<T, M> dataRepository, object item)
            where T : class
            where M : class
        {
            //add with validation
            string[] errors = new string[] { };
            string exceptionTrace = "";
            if (!dataRepository.Add(ref errors, ref exceptionTrace, (T)item))
            {
                if (errors.Length > 0)
                    throw new ArgumentException(String.Join("\r\n", errors));
                else if (!String.IsNullOrEmpty(exceptionTrace))
                    throw new DataException(exceptionTrace);
                else
                    throw new ArgumentException("Unknown error happened.\n");
            }
        }

        /// <summary>
        /// Validate and Update a record
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="M"></typeparam>
        /// <param name="dataRepository"></param>
        /// <param name="item"></param>
        public static void Update<T, M>(GenericDataRepository<T, M> dataRepository, object item)
            where T : class
            where M : class
        {
            //update with validation
            string[] errors = new string[] { };
            string exceptionTrace = "";
            if (!dataRepository.Update(ref errors, ref exceptionTrace, (T)item))
            {
                if (errors.Length > 0)
                    throw new ArgumentException(String.Join("\r\n", errors));
                else if (!String.IsNullOrEmpty(exceptionTrace))
                    throw new DataException(exceptionTrace);
                else
                    throw new ArgumentException("Unknown error happened.\n");
            }
        }

        /// <summary>
        /// Validate and Remove a record
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="M"></typeparam>
        /// <param name="checkForeingKeys"></param>
        /// <param name="excludedForeingKeys"></param>
        /// <param name="dataRepository"></param>
        /// <param name="item"></param>
        public static void Remove<T, M>(bool checkForeingKeys, string[] excludedForeingKeys, GenericDataRepository<T, M> dataRepository, object item)
            where T : class
            where M : class
        {
            //remove with validation
            string[] errors = new string[] { };
            string exceptionTrace = "";
            if (!dataRepository.Remove(checkForeingKeys, excludedForeingKeys, ref errors, ref exceptionTrace, (T)item))
            {
                if (errors.Length > 0)
                    throw new ArgumentException(String.Join("\r\n", errors));
                else if (!String.IsNullOrEmpty(exceptionTrace))
                    throw new DataException(exceptionTrace);
                else
                    throw new ArgumentException("Unknown error happened.\n");
            }
        }

        /// <summary>
        /// Validate and Remove a record
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="M"></typeparam>
        /// <param name="checkForeingKeys"></param>
        /// <param name="dataRepository"></param>
        /// <param name="item"></param>
        public static void Remove<T, M>(bool checkForeingKeys, GenericDataRepository<T, M> dataRepository, object item)
            where T : class
            where M : class
        {
            Remove(checkForeingKeys, null, dataRepository, item);
        }

        /// <summary>
        /// Validate and Remove a record, check for foreing keys
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="M"></typeparam>
        /// <param name="dataRepository"></param>
        /// <param name="item"></param>
        public static void Remove<T, M>(GenericDataRepository<T, M> dataRepository, object item)
            where T : class
            where M : class
        {
            Remove(true, null, dataRepository, item);
        }

        /// <summary>
        /// Get the underlying database name of a repository
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="M"></typeparam>
        /// <param name="dataRepository"></param>
        /// <returns></returns>
        public static string GetDatabaseName<T, M>(GenericDataRepository<T, M> dataRepository)
            where T : class
            where M : class
        {
            //get database name
            return dataRepository.Helper.GetDatabaseName();
        }

        /// <summary>
        /// Get the underlying table name of a repository 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="M"></typeparam>
        /// <param name="dataRepository"></param>
        /// <returns></returns>
        public static string GetTableName<T, M>(GenericDataRepository<T, M> dataRepository)
            where T : class
            where M : class
        {
            //get table name
            return dataRepository.Helper.GetTableName();
        }

        /// <summary>
        /// Get a ConcurrencyHelperRecord from a repository
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="M"></typeparam>
        /// <param name="dataRepository"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public static Nullable<DGUIGHFForm.ConcurrencyHelperRecord> GetConcurrencyHelperRecord<T, M>(GenericDataRepository<T, M> dataRepository, object item)
            where T : class
            where M : class
        {
            Nullable<DGUIGHFForm.ConcurrencyHelperRecord> ret = null;
            if (item != null)
            {
                //get database name
                string database = GetDatabaseName<T, M>(dataRepository);
                //get database table name
                string table = GetTableName<T, M>(dataRepository);
                //get record id, i.e. serialized keys
                string recordId = GetKeyPairsToJson<T, M>(dataRepository, item);
                if (!String.IsNullOrEmpty(database) && !String.IsNullOrEmpty(table) && !String.IsNullOrEmpty(recordId))
                {
                    //build the concurrencyhelperrecord
                    ret = new DGUIGHFForm.ConcurrencyHelperRecord(database, table, recordId);
                }
            }
            return ret;
        }

        /// <summary>
        /// Get the underlying key pairs of a repository 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="M"></typeparam>
        /// <param name="dataRepository"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public static IDictionary<string, object> GetKeyPairs<T, M>(GenericDataRepository<T, M> dataRepository, object item)
            where T : class
            where M : class
        {
            //get key pairs
            return dataRepository.Helper.GetKeyPairs((T)item);
        }

        /// <summary>
        /// Get the underlying key pairs of a repository and serialize to JSON
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="M"></typeparam>
        /// <param name="dataRepository"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public static string GetKeyPairsToJson<T, M>(GenericDataRepository<T, M> dataRepository, object item)
            where T : class
            where M : class
        {
            IDictionary<string, object> dictionary = dataRepository.Helper.GetKeyPairs((T)item);
            int i = 0;
            return "{ " + string.Join(", ", dictionary.Select(d => string.Format((int.TryParse(d.Value.ToString(), out i) ? "\"{0}\": {1}" : "\"{0}\": \"{1}\""), d.Key, d.Value))) + " }";
        }

        /// <summary>
        /// Check if property values are changed
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="M"></typeparam>
        /// <param name="dataRepository"></param>
        /// <param name="item"></param>
        /// <param name="originalDbPropertyValues"></param>
        /// <returns></returns>
        public static bool ArePropertyValuesChanged<T, M>(GenericDataRepository<T, M> dataRepository, object item, IDictionary<string, object> originalDbPropertyValues)
            where T : class
            where M : class
        {
            //check if propertyvalues are changed
            return dataRepository.Helper.ArePropertyValuesChanged((T)item, originalDbPropertyValues);
        }

        /// <summary>
        /// Get property values from a repository
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="M"></typeparam>
        /// <param name="dataRepository"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public static IDictionary<string, object> GetOriginalValues<T, M>(GenericDataRepository<T, M> dataRepository, object item)
            where T : class
            where M : class
        {
            //get current original values
            return dataRepository.Helper.GetPropertyValues((T)item);
        }

        /// <summary>
        /// Load an entity from the current element of BindingSource loaded with a DataTable
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="M"></typeparam>
        /// <param name="dataRepository"></param>
        /// <param name="bindingSource"></param>
        /// <param name="fieldNames"></param>
        /// <returns></returns>
        public static object LoadEntityFromCurrentBindingSource<T, M>(GenericDataRepository<T, M> dataRepository, BindingSource bindingSource, string[] fieldNames)
            where T : class
            where M : class
        {
            object ret = null;
            if (bindingSource.Current != null)
            {
                object[] keyvalues = new object[] { };
                foreach (string fieldName in fieldNames)
                {
                    //find the key value from a field
                    object fieldId = (((DataRowView)bindingSource.Current).Row).Field<object>(fieldName);
                    keyvalues = keyvalues.Concat(new object[] { fieldId }).ToArray();
                }
                //find the repository item
                ret = dataRepository.Find(keyvalues);
            }
            return ret;
        }

        /// <summary>
        /// Load an entity from the current element of BindingSource loaded with a DataTable
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="M"></typeparam>
        /// <param name="dataRepository"></param>
        /// <param name="selectedKeys"></param>
        /// <returns></returns>
        public static object[] LoadEntitiesFromSelectedKeys<T, M>(GenericDataRepository<T, M> dataRepository, IList<object[]> selectedKeys)
            where T : class
            where M : class
        {
            object[] ret = new object[] { };
            foreach (object[] selectedKey in selectedKeys)
            {
                object found = dataRepository.Find(selectedKey);
                ret = ret.Concat(new object[] { found }).ToArray();
            }
            return ret;
        }

        /// <summary>
        /// Load a property values for an entity loaded by the current element of BindingSource loaded with a DataTable
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="M"></typeparam>
        /// <param name="dataRepository"></param>
        /// <param name="bindingSource"></param>
        /// <param name="fieldNames"></param>
        /// <returns></returns>
        public static IDictionary<string, object> LoadPropertyValuesFromCurrentBindingSource<T, M>(GenericDataRepository<T, M> dataRepository, BindingSource bindingSource, string[] fieldNames)
            where T : class
            where M : class
        {
            IDictionary<string, object> ret = null;
            if (bindingSource.Current != null)
            {
                object[] keyvalues = new object[] { };
                foreach (string fieldName in fieldNames)
                {
                    //find the key value from a field
                    object fieldId = (((DataRowView)bindingSource.Current).Row).Field<object>(fieldName);
                    keyvalues = keyvalues.Concat(new object[] { fieldId }).ToArray();
                }
                //find the repository item
                T item = dataRepository.Find(keyvalues);
                if (item != null)
                {
                    //get property values
                    ret = dataRepository.Helper.GetPropertyValues(item);
                }
            }
            return ret;
        }

        /// <summary>
        /// Set the BindingSource position selecting the key pairs from an entity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="M"></typeparam>
        /// <param name="dataRepository"></param>
        /// <param name="item"></param>
        /// <param name="bindingSource"></param>
        public static bool SetBindingSourcePosition<T, M>(GenericDataRepository<T, M> dataRepository, object item, BindingSource bindingSource)
            where T : class
            where M : class
        {
            bool ret = false;
            if (item != null)
            {
                //get key for the item
                IDictionary<string, object> keypairs = dataRepository.Helper.GetKeyPairs((T)item);
                if (keypairs != null)
                {
                    //consider just the first key
                    if (keypairs.Count > 0)
                    {
                        //set the bindingsource position
                        bindingSource.Position = bindingSource.Find(keypairs.FirstOrDefault().Key, keypairs.FirstOrDefault().Value);
                        ret = true;
                    }
                }
            }
            return ret;
        }
    }
}

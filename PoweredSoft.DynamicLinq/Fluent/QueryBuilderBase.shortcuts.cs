﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PoweredSoft.DynamicLinq.Fluent
{
    public abstract partial class QueryBuilderBase
    {
        public QueryBuilderBase And(string path, ConditionOperators conditionOperator, object value,
            QueryConvertStrategy convertStrategy = QueryConvertStrategy.ConvertConstantToComparedPropertyOrField, QueryCollectionHandling collectionHandling = QueryCollectionHandling.Any, StringComparison? stringComparision = null)
            => Compare(path, conditionOperator, value, convertStrategy: convertStrategy, collectionHandling: collectionHandling, and: true, stringComparision: stringComparision);

        public QueryBuilderBase Or(string path, ConditionOperators conditionOperator, object value,
            QueryConvertStrategy convertStrategy = QueryConvertStrategy.ConvertConstantToComparedPropertyOrField, QueryCollectionHandling collectionHandling = QueryCollectionHandling.Any, StringComparison? stringComparision = null)
            => Compare(path, conditionOperator, value, convertStrategy: convertStrategy, collectionHandling: collectionHandling, and: false, stringComparision: stringComparision);

        public QueryBuilderBase And(Action<QueryBuilderBase> subQuery)
            => SubQuery(subQuery, true);

        public QueryBuilderBase Or(Action<QueryBuilderBase> subQuery)
            => SubQuery(subQuery, false);

        #region equal
        public QueryBuilderBase Equal(string path, object value, QueryConvertStrategy convertStrategy = QueryConvertStrategy.ConvertConstantToComparedPropertyOrField, QueryCollectionHandling collectionHandling = QueryCollectionHandling.Any, StringComparison? stringComparision = null)
            => And(path, ConditionOperators.Equal, value, convertStrategy: convertStrategy, collectionHandling: collectionHandling, stringComparision: stringComparision);

        public QueryBuilderBase AndEqual(string path, object value, QueryConvertStrategy convertStrategy = QueryConvertStrategy.ConvertConstantToComparedPropertyOrField, QueryCollectionHandling collectionHandling = QueryCollectionHandling.Any, StringComparison? stringComparision = null)
            => And(path, ConditionOperators.Equal, value, convertStrategy: convertStrategy, collectionHandling: collectionHandling, stringComparision: stringComparision);

        public QueryBuilderBase OrEqual(string path, object value, QueryConvertStrategy convertStrategy = QueryConvertStrategy.ConvertConstantToComparedPropertyOrField, QueryCollectionHandling collectionHandling = QueryCollectionHandling.Any, StringComparison? stringComparision = null)
            => Or(path, ConditionOperators.Equal, value, convertStrategy: convertStrategy, collectionHandling: collectionHandling, stringComparision: stringComparision);
        #endregion

        #region not equal
        public QueryBuilderBase NotEqual(string path, object value, QueryConvertStrategy convertStrategy = QueryConvertStrategy.ConvertConstantToComparedPropertyOrField, QueryCollectionHandling collectionHandling = QueryCollectionHandling.Any, StringComparison? stringComparision = null)
            => And(path, ConditionOperators.NotEqual, value, convertStrategy: convertStrategy, collectionHandling: collectionHandling, stringComparision: stringComparision);

        public QueryBuilderBase AndNotEqual(string path, object value, QueryConvertStrategy convertStrategy = QueryConvertStrategy.ConvertConstantToComparedPropertyOrField, QueryCollectionHandling collectionHandling = QueryCollectionHandling.Any, StringComparison? stringComparision = null)
            => And(path, ConditionOperators.NotEqual, value, convertStrategy: convertStrategy, collectionHandling: collectionHandling, stringComparision: stringComparision);

        public QueryBuilderBase OrNotEqual(string path, object value, QueryConvertStrategy convertStrategy = QueryConvertStrategy.ConvertConstantToComparedPropertyOrField, QueryCollectionHandling collectionHandling = QueryCollectionHandling.Any, StringComparison? stringComparision = null)
            => Or(path, ConditionOperators.NotEqual, value, convertStrategy: convertStrategy, collectionHandling: collectionHandling, stringComparision: stringComparision);
        #endregion

        #region GreaterThan
        public QueryBuilderBase GreaterThan(string path, object value, QueryConvertStrategy convertStrategy = QueryConvertStrategy.ConvertConstantToComparedPropertyOrField, QueryCollectionHandling collectionHandling = QueryCollectionHandling.Any)
            => And(path, ConditionOperators.GreaterThan, value, convertStrategy: convertStrategy, collectionHandling: collectionHandling);

        public QueryBuilderBase AndGreaterThan(string path, object value, QueryConvertStrategy convertStrategy = QueryConvertStrategy.ConvertConstantToComparedPropertyOrField, QueryCollectionHandling collectionHandling = QueryCollectionHandling.Any)
            => And(path, ConditionOperators.GreaterThan, value, convertStrategy: convertStrategy, collectionHandling: collectionHandling);

        public QueryBuilderBase OrGreaterThan(string path, object value, QueryConvertStrategy convertStrategy = QueryConvertStrategy.ConvertConstantToComparedPropertyOrField, QueryCollectionHandling collectionHandling = QueryCollectionHandling.Any)
            => Or(path, ConditionOperators.GreaterThan, value, convertStrategy: convertStrategy, collectionHandling: collectionHandling);
        #endregion

        #region GreaterThanOrEqual
        public QueryBuilderBase GreaterThanOrEqual(string path, object value, QueryConvertStrategy convertStrategy = QueryConvertStrategy.ConvertConstantToComparedPropertyOrField, QueryCollectionHandling collectionHandling = QueryCollectionHandling.Any)
            => And(path, ConditionOperators.GreaterThanOrEqual, value, convertStrategy: convertStrategy, collectionHandling: collectionHandling);

        public QueryBuilderBase AndGreaterThanOrEqual(string path, object value, QueryConvertStrategy convertStrategy = QueryConvertStrategy.ConvertConstantToComparedPropertyOrField, QueryCollectionHandling collectionHandling = QueryCollectionHandling.Any)
            => And(path, ConditionOperators.GreaterThanOrEqual, value, convertStrategy: convertStrategy, collectionHandling: collectionHandling);

        public QueryBuilderBase OrGreaterThanOrEqual(string path, object value, QueryConvertStrategy convertStrategy = QueryConvertStrategy.ConvertConstantToComparedPropertyOrField, QueryCollectionHandling collectionHandling = QueryCollectionHandling.Any)
            => Or(path, ConditionOperators.GreaterThanOrEqual, value, convertStrategy: convertStrategy, collectionHandling: collectionHandling);
        #endregion

        #region LessThan
        public QueryBuilderBase LessThan(string path, object value, QueryConvertStrategy convertStrategy = QueryConvertStrategy.ConvertConstantToComparedPropertyOrField, QueryCollectionHandling collectionHandling = QueryCollectionHandling.Any)
            => And(path, ConditionOperators.LessThan, value, convertStrategy: convertStrategy, collectionHandling: collectionHandling);

        public QueryBuilderBase AndLessThan(string path, object value, QueryConvertStrategy convertStrategy = QueryConvertStrategy.ConvertConstantToComparedPropertyOrField, QueryCollectionHandling collectionHandling = QueryCollectionHandling.Any)
            => And(path, ConditionOperators.LessThan, value, convertStrategy: convertStrategy, collectionHandling: collectionHandling);

        public QueryBuilderBase OrLessThan(string path, object value, QueryConvertStrategy convertStrategy = QueryConvertStrategy.ConvertConstantToComparedPropertyOrField, QueryCollectionHandling collectionHandling = QueryCollectionHandling.Any)
            => Or(path, ConditionOperators.LessThan, value, convertStrategy: convertStrategy, collectionHandling: collectionHandling);
        #endregion

        #region LessThanOrEqual
        public QueryBuilderBase LessThanOrEqual(string path, object value, QueryConvertStrategy convertStrategy = QueryConvertStrategy.ConvertConstantToComparedPropertyOrField, QueryCollectionHandling collectionHandling = QueryCollectionHandling.Any)
            => And(path, ConditionOperators.LessThanOrEqual, value, convertStrategy: convertStrategy, collectionHandling: collectionHandling);

        public QueryBuilderBase AndLessThanOrEqual(string path, object value, QueryConvertStrategy convertStrategy = QueryConvertStrategy.ConvertConstantToComparedPropertyOrField, QueryCollectionHandling collectionHandling = QueryCollectionHandling.Any)
            => And(path, ConditionOperators.LessThanOrEqual, value, convertStrategy: convertStrategy, collectionHandling: collectionHandling);

        public QueryBuilderBase OrLessThanOrEqual(string path, object value, QueryConvertStrategy convertStrategy = QueryConvertStrategy.ConvertConstantToComparedPropertyOrField, QueryCollectionHandling collectionHandling = QueryCollectionHandling.Any)
            => Or(path, ConditionOperators.LessThanOrEqual, value, convertStrategy: convertStrategy, collectionHandling: collectionHandling);
        #endregion

        #region contains
        public QueryBuilderBase Contains(string path, object value, QueryConvertStrategy convertStrategy = QueryConvertStrategy.ConvertConstantToComparedPropertyOrField, QueryCollectionHandling collectionHandling = QueryCollectionHandling.Any, StringComparison? stringComparision = null)
            => And(path, ConditionOperators.Contains, value, convertStrategy: convertStrategy, collectionHandling: collectionHandling, stringComparision: stringComparision);

        public QueryBuilderBase AndContains(string path, object value, QueryConvertStrategy convertStrategy = QueryConvertStrategy.ConvertConstantToComparedPropertyOrField, QueryCollectionHandling collectionHandling = QueryCollectionHandling.Any, StringComparison? stringComparision = null)
            => And(path, ConditionOperators.Contains, value, convertStrategy: convertStrategy, collectionHandling: collectionHandling, stringComparision: stringComparision);

        public QueryBuilderBase OrContains(string path, object value, QueryConvertStrategy convertStrategy = QueryConvertStrategy.ConvertConstantToComparedPropertyOrField, QueryCollectionHandling collectionHandling = QueryCollectionHandling.Any, StringComparison? stringComparision = null)
            => Or(path, ConditionOperators.Contains, value, convertStrategy: convertStrategy, collectionHandling: collectionHandling, stringComparision: stringComparision);
        #endregion

        #region starts with
        public QueryBuilderBase StartsWith(string path, object value, QueryConvertStrategy convertStrategy = QueryConvertStrategy.ConvertConstantToComparedPropertyOrField, QueryCollectionHandling collectionHandling = QueryCollectionHandling.Any, StringComparison? stringComparision = null)
            => And(path, ConditionOperators.StartsWith, value, convertStrategy: convertStrategy, collectionHandling: collectionHandling, stringComparision: stringComparision);

        public QueryBuilderBase AndStartsWith(string path, object value, QueryConvertStrategy convertStrategy = QueryConvertStrategy.ConvertConstantToComparedPropertyOrField, QueryCollectionHandling collectionHandling = QueryCollectionHandling.Any, StringComparison? stringComparision = null)
            => And(path, ConditionOperators.StartsWith, value, convertStrategy: convertStrategy, collectionHandling: collectionHandling, stringComparision: stringComparision);

        public QueryBuilderBase OrStartsWith(string path, object value, QueryConvertStrategy convertStrategy = QueryConvertStrategy.ConvertConstantToComparedPropertyOrField, QueryCollectionHandling collectionHandling = QueryCollectionHandling.Any, StringComparison? stringComparision = null)
            => Or(path, ConditionOperators.StartsWith, value, convertStrategy: convertStrategy, collectionHandling: collectionHandling, stringComparision: stringComparision);
        #endregion

        #region ends with
        public QueryBuilderBase EndsWith(string path, object value, QueryConvertStrategy convertStrategy = QueryConvertStrategy.ConvertConstantToComparedPropertyOrField, QueryCollectionHandling collectionHandling = QueryCollectionHandling.Any, StringComparison? stringComparision = null)
            => And(path, ConditionOperators.EndsWith, value, convertStrategy: convertStrategy, collectionHandling: collectionHandling, stringComparision: stringComparision);

        public QueryBuilderBase AndEndsWith(string path, object value, QueryConvertStrategy convertStrategy = QueryConvertStrategy.ConvertConstantToComparedPropertyOrField, QueryCollectionHandling collectionHandling = QueryCollectionHandling.Any, StringComparison? stringComparision = null)
            => And(path, ConditionOperators.EndsWith, value, convertStrategy: convertStrategy, collectionHandling: collectionHandling, stringComparision: stringComparision);

        public QueryBuilderBase OrEndsWith(string path, object value, QueryConvertStrategy convertStrategy = QueryConvertStrategy.ConvertConstantToComparedPropertyOrField, QueryCollectionHandling collectionHandling = QueryCollectionHandling.Any, StringComparison? stringComparision = null)
            => Or(path, ConditionOperators.EndsWith, value, convertStrategy: convertStrategy, collectionHandling: collectionHandling, stringComparision: stringComparision);
        #endregion
    }
}

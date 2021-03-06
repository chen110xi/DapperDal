﻿using System;
using System.Linq.Expressions;
using Dapper.Extensions.Linq.Builder;

namespace DapperExtensions.Expressions
{
    public static class DapperExpressionExtensions
    {
        public static IPredicate ToPredicateGroup<TEntity, TPrimaryKey>(
            this Expression<Func<TEntity, bool>> expression) where TEntity : class
        {
            if (expression == null)
            {
                return null;
            }

            //var dev = new DapperExpressionVisitor<TEntity, TPrimaryKey>();
            //IPredicate pg = dev.Process(expression);

            IPredicate pg = QueryBuilder<TEntity>.FromExpression(expression);

            return pg;
        }
    }
}

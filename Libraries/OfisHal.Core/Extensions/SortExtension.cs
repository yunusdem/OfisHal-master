using System.Linq.Expressions;

namespace System.Linq
{
    public static class SortExtension
    {
        public static IOrderedQueryable<T> OrderBy<T>(this IQueryable<T> source, string property, bool ascending) => 
            ApplyOrder(source, property, ascending ? "OrderBy" : "OrderByDescending");

        public static IOrderedQueryable<T> OrderBy<T>(this IQueryable<T> source, string property) => 
            ApplyOrder(source, property, "OrderBy");

        public static IOrderedQueryable<T> OrderByDescending<T>(this IQueryable<T> source, string property) => 
            ApplyOrder(source, property, "OrderByDescending");

        public static IOrderedQueryable<T> ThenBy<T>(this IOrderedQueryable<T> source, string property) => 
            ApplyOrder(source, property, "ThenBy");

        public static IOrderedQueryable<T> ThenByDescending<T>(this IOrderedQueryable<T> source, string property) => 
            ApplyOrder(source, property, "ThenByDescending");

        private static IOrderedQueryable<T> ApplyOrder<T>(this IQueryable<T> queryable, string propertyName, string sortMethodName)
        {
            //build an expression tree that can be passed as lambda to IQueryable#OrderBy
            var type = typeof(T);
            var paramExpression = Expression.Parameter(type, "parameterExpression");

            var property = type.GetProperty(propertyName);
            var propertyExpression = Expression.Property(paramExpression, property);

            var lambdaType = typeof(Func<,>).MakeGenericType(type, property.PropertyType);
            var lambdaExpression = Expression.Lambda(lambdaType, propertyExpression, paramExpression);

            // dynamically generate a method with the correct type parameters
            var queryableType = typeof(Queryable);
            var orderByMethod = queryableType.GetMethods()
                .Single(m => m.Name == sortMethodName &&
                             m.IsGenericMethodDefinition
                             && m.GetGenericArguments().Length == 2
                             && m.GetParameters().Length == 2)
                .MakeGenericMethod(type, property.PropertyType);

            var result = orderByMethod.Invoke(null, new object[] { queryable, lambdaExpression });
            return (IOrderedQueryable<T>)result;
        }
    }
}

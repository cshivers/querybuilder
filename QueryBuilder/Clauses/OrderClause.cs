using SqlKata.Expressions;

namespace SqlKata.QueryBuilder
{
    public class OrderByClause : AbstractClause
    {
        public Expression Expression { get; set; }
        public bool Descending { get; set; } = false;

        /// <inheritdoc />
        public override AbstractClause Clone()
        {
            return new OrderByClause
            {
                Engine = Engine,
                Component = Component,
                Expression = Expression.Clone(),
                Descending = Descending
            };
        }
    }

}
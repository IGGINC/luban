using Luban.Job.Cfg.DataVisitors;

namespace Luban.Job.Cfg.Datas
{
    public class DBytes : DType<byte[]>
    {

        public override string TypeName => "bytes";

        public DBytes(byte[] x) : base(x)
        {
        }

        public override bool Equals(object obj)
        {
            return obj is DBytes d && System.Collections.StructuralComparisons.StructuralEqualityComparer.Equals(Value, d.Value);
        }

        public override int GetHashCode()
        {
            throw new System.NotSupportedException();
        }

        public override void Apply<T>(IDataActionVisitor<T> visitor, T x)
        {
            visitor.Accept(this, x);
        }

        public override void Apply<T1, T2>(IDataActionVisitor<T1, T2> visitor, T1 x, T2 y)
        {
            visitor.Accept(this, x, y);
        }

        public override TR Apply<TR>(IDataFuncVisitor<TR> visitor)
        {
            return visitor.Accept(this);
        }

        public override TR Apply<T, TR>(IDataFuncVisitor<T, TR> visitor, T x)
        {
            return visitor.Accept(this, x);
        }
    }
}

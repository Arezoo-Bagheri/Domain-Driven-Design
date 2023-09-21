namespace DDDExample.ValueObjects.Moneyv2
{
    public class Money : BaseValueObject<Money>
    {

        protected readonly decimal Value;

        protected override int GetHashCodeCore()
        {
             return Value.GetHashCode();
        }

        protected override bool IsEqual(Money other)
        {
             return Value == other.Value;
        }
    }
}

namespace prototypeDesignePattren
{
    public class ConsertProp1: prototype
    {
        //constroctor
        public ConsertProp1(string id): base(id)
        {
            
        }

        //return shallow copy
        public override prototype clone()
        {
            return (prototype)this.MemberwiseClone();
        }
    }

    public class ConsertProp2: prototype
    {
        //constroctor
        public ConsertProp2(string id): base(id)
        {
            
        }

        //return shallow copy
        public override prototype clone()
        {
            return (prototype)this.MemberwiseClone();
        }
    }
}
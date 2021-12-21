namespace prototypeDesignePattren
{
    public abstract class prototype
    {
        //constractor
        public string _id;
        public prototype(string id)
        {
            _id = id;

        }
        //Get id => return Id
        public string Id { get{ return _id;}}

        //method clone
        public abstract prototype clone();

    }

    
}
namespace GitExercise
{
    class myClass
    {
        public string _name;
        public string _address;
        public int _postNr;
        public myClass(string Name, string Address, int postNr){
            _name = Name;
            _address = Address;
            _postNr = postNr;
        }

        public string Name{
            get {return _name; }
        }
        public string Address{
            get {return _address; }
        }
        public int postNr{
            get {return _postNr; }
        }
    }
}
using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {

            JSONBuilder j = new JSONBuilder();

            j.beginBracket().setKeyValue("name", "abdullah").setKeyValue("age", "23").endBracket();

            Console.WriteLine(j.get());

        }
    }

    class JSONBuilder
    {
        private string JSON;

        public JSONBuilder beginBracket()
        {
            this.JSON += "{\n";
            return this;
        }
        public JSONBuilder endBracket()
        {
            this.JSON += "}";
            return this;
        }

        public JSONBuilder setKeyValue(string key,string value)
        {
            this.JSON += key + ":" + value +",\n";
            return this;
        }
        public string get()
        {
            return this.JSON;
        }

        public string getAndClear()
        {
            string str = this.JSON;
            JSON = "";
            return str;
        }
    }
}

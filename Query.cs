namespace Academy
{

    public class Query
    {
        public string Tables { get; set; }
        public string Fields { get; set; }
        public string Condition { get; set; }

        public Query(string tables, string fields, string condition = "")
        {
            Tables = tables;
            Fields = fields;
            Condition = condition;
        }

        public override string ToString()
        {
            string cmd = $"SELECT {Fields} FROM {Tables}";
            if (Condition != "" && Condition != " ") cmd += $" WHERE {Condition}";
            cmd += ";";
            return cmd;
        }
    }
}
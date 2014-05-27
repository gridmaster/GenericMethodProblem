namespace GenericMethodProblem
{
    public class Models
    {
        public abstract class MyBass
        {
            public string FieldOne { get; set; }
            public abstract T LoadRow<T>(string[] rows) where T : class;
        }

        public class ReturnEx1 : MyBass
        {
            public string FieldTwo { get; set; }

            public override T LoadRow<T>(string[] rows)
            {
                FieldOne = rows[0];
                FieldTwo = rows[1];
                return this as T;
            }
        }

        public class ReturnEx2 : MyBass
        {
            public string FieldThree { get; set; }
            public string FieldFour { get; set; }

            public override T LoadRow<T>(string[] rows)
            {
                FieldOne = rows[0];
                FieldThree = rows[1];
                FieldFour = rows[2];
                return this as T;
            }
        }
    }
}

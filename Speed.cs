namespace igen
{
    public class Speed
    {
        public string Name;
        public int Time;
        public int Runner_speed;
        private int Sex;

        public Speed(int sex)
        {
            Sex = sex;
        }
        public int count ()
        {
            int distance = Runner_speed * Time;
            return distance;
        }
    }
}

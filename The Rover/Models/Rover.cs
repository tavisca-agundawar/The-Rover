using System.Text;

namespace The_Rover
{
    public class Rover
    {
        public char Direction { get; set; }
        public Coordinate Position { get; set; }

        public string GetRoverDetails()
        {
            var details = new StringBuilder()
                          .Append(Position.X.ToString() + ", ")
                          .Append(Position.Y.ToString()+ ", ")
                          .Append(Direction)
                          .ToString();
            return details;
        }
    }
}

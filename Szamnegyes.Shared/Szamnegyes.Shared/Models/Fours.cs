using System.ComponentModel.DataAnnotations;

namespace Szamnegyes.Shared.Models
{
    public class Fours
    {
        [Key]
        public int Id { get; set; }
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public int D { get; set; }


        public Fours(int a, int b, int c, int d)
        {
            A = a; B = b; C = c; D = d;
            Id = A * 1000 + B * 100 + C * 10 + D;
        }

        public Fours()
        {
            
        }

    }
}

namespace SzamnegyesProject.Models
{
    public class Szamnegyes
    {
        public Guid id { get; set; } = Guid.NewGuid();
        public int[] fours = new int[4];

        public Szamnegyes()
        {
            
        }

        public void Increase()
        {
            for(int i = 0; i<4;i++)
            {
                fours[i]++;
            }
        }

        public void NullTable()
        {
            fours = new int[4];
        }
    }
}

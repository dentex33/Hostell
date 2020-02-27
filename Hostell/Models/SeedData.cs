using System.Linq;

namespace Hostell.Models
{
    public class SeedData
    {
        public static void Initializate(HostelAppContext database)
        {
            if (!database.Blocks.Any())
            {
                database.Blocks.AddRange(
                    new Block
                    {
                        NoBlock = "1310",
                        Floor = 3,
                        Balcony = true,
                        NumberOfPlace = 5,
                        OccupiedPlace = 5
                    },
                    new Block
                    {
                        NoBlock = "1405",
                        Floor = 4,
                        Balcony = true,
                        NumberOfPlace = 5,
                        OccupiedPlace = 5

                    },
                     new Block
                     {
                         NoBlock = "1110",
                         Floor = 1,
                         Balcony = false,
                         NumberOfPlace = 5,
                         OccupiedPlace = 5
                     });
                database.SaveChanges();
            }
            if (!database.Residents.Any())
            {
                database.Residents.AddRange(
                    new Resident
                    {
                        Name = "Андрей",
                        Sname = "Морочко",
                        Adress = "Бытень",
                        DateOfBirthday = "12.02.2000",
                        PhoneNumber = "+375293454621",
                        BlockId = 1
                    },
                    new Resident
                    {
                        Name = "Алексей",
                        Sname = "Лелес",
                        Adress = "Ганцевичи",
                        DateOfBirthday = "26.06.2000",
                        PhoneNumber = "+37529456454345",
                        BlockId = 1
                    });
                database.SaveChanges();
            }


        }
    }
}

using Microsoft.EntityFrameworkCore;

public static class SeedData
{
    public static void Seed(ModelBuilder builder){
        builder.Entity<HouseEntity>().HasData(new List<HouseEntity>{
            new HouseEntity {
                Id = 1,
                Address = "12 Valley of Kings, Geneva",
                Country = "Switzerland",
                Description = "A superb detached Victorian property on the road to ROME",
                Price = 900000
            },
            new HouseEntity {
                Id = 2,
                Address = "89 Road of Forks, Bern",
                Country = "Switzerland",
                Description = "A superb detached Spartan property in the city",
                Price = 900000
            }
        });
    }
}
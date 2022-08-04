using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PizzaOnLine.Models
{
    public class PizzaDbInitializer : DropCreateDatabaseAlways<PizzaContext>
    {
        protected override void Seed(PizzaContext db)
        {
            db.Pizzas.Add(new Pizza 
            { 
                Name = "Пепперони", 
                Description = "Cыры Моцарелла и Пармезан, шампиньоны, бекон, колбаса пепперони, помидоры, куриная грудка, чеснок, лук красный, зелень.", 
                Price = 220,
                Image = "Pepperoni.jpg"
            });
            db.Pizzas.Add(new Pizza
            { 
                Name = "Маргарита", 
                Description = "Cыр Моцарелла, помидоры.", 
                Price = 200,
                Image = "Margarita.jpg"
            });
            db.Pizzas.Add(new Pizza 
            { 
                Name = "Гавайская", 
                Description = "Cыр Моцарелла, ветчина, ананасы.", 
                Price = 200,
                Image = "Нawaiian.jpg"
            });

            base.Seed(db);
        }
    }
}

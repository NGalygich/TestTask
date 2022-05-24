namespace TestTask;

static class Program{
    public static void Main(){
        using (UsersDataBaseContext db = new UsersDataBaseContext())
        {
            // создаем два объекта User
            User Dmitriy = new User { name = "Dmitriy", password = "asdfg" };
            //User Alisa = new User { name = "Alisa", password = "qaz123" };
        
            // добавляем их в бд
            db.Users.Add(Dmitriy);
            //db.Users.Add(Alisa);
            db.SaveChanges();
            Console.WriteLine("Объекты успешно сохранены");
        
            // получаем объекты из бд и выводим на консоль
            var users = db.Users.ToList();
            Console.WriteLine("Список объектов:");
            foreach (User u in users)
            {
                Console.WriteLine($"{u.id}.{u.name} - {u.password}");
            }
        }

    }
    
    public static void Authorization(){

    }
    public static void Registration(){

    }
    public static void ChangeStatus(){

    }
    public static void WriteInfo(){

    }
}
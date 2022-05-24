namespace TestTask;

static class Program{
    public static void Main(){
        Authorization();
    }
    
    public static void Authorization(){
        User user = new User();
        Console.Write("Введите имя: ");
        user.name = Console.ReadLine();
        Console.Write("Введите пароль: ");
        user.password = Console.ReadLine();
        using (UsersDataBaseContext db = new UsersDataBaseContext()){
            var users = db.Users.ToList();
            foreach (var u in users){
                if ((user.name == u.name) && (user.password == u.password)){
                    Menu();
                }
            }
            Console.WriteLine("Пользователь не найден. Зарегестрируйтесь.");
            Registration(db);
        }
    }
    public static void Registration(UsersDataBaseContext db){
        User user = new User();
        Console.Write("Придумайте имя: ");
        user.name = Console.ReadLine();
        Console.Write("Придумайте пароль: ");
        user.password = Console.ReadLine();
        var users = db.Users.ToList();
        foreach (User u in users){
            if (user.name == u.name){
                Console.WriteLine("Имя пользователя уже занято. Придумайте другое.");
                Console.ReadLine();
                Console.Clear();
                Registration(db);
            }
        }
            db.Users.Add(user);
            db.SaveChanges();
            Console.WriteLine("Вы зарегестрированы.");
            Menu();
    }
    public static void ChangeStatus(){

    }
    public static void WriteInfo(){

    }
    public static void Menu(){
        Console.Write("Выберите действие.");
        Console.ReadLine();
    }
}
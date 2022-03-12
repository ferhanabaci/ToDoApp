namespace ToDoApp{
    public class User{
        public int Id {get;set;}
        public string FullName{get;set;}
        
        public User(int id,string fullname){
            Id=id;
            FullName=fullname;
        }
    }
}
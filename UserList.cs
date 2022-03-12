using System.Collections.Generic;
namespace ToDoApp{
    public class UserList{
        public List<User> all= new List<User>();

        public UserList(){
            all.Add(new User(1,"Ferhan Abacı"));
            all.Add(new User(2,"Sıla "));
            all.Add(new User(3,"Cahide"));
            all.Add(new User(4,"Erugrul"));
            
        }
    }
}
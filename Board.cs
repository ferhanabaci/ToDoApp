using System.Collections.Generic;
namespace ToDoApp{
    public class Board{
        public List<Card> TODO = new List<Card>();
        public List<Card> IN_PROGRESS = new List<Card>();
        public List<Card> DONE = new List<Card>();

        public Board(){
            TODO.Add(new Card("Ödev Yap", "Ödev Yap.",1,1));
            IN_PROGRESS.Add(new Card("Deploy","Book Store Uygulamasını Yayınla",2,3));
            DONE.Add(new Card("Build All","Book Store build al ",3,4));
        }
        public List<Card> GetProperty(string str){
            if (str =="TODO")
                return this.TODO;
            else if(str ==" IN_PROGRESS")
                return this.IN_PROGRESS;
            else
                return this.DONE;
        }
    }
}
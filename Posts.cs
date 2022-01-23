using System;
using System.Collections.Generic;
using System.Text;


namespace lab12
{
    class Posts: Workers
    {
        public Posts() { }
        public Posts Set(Name _name, string _post)
        {
            Posts posts = this;
            this.nameP = _name;
            this.postP = _post;
            return posts;
        }
        public void GetPostsFromWorker(Workers worker)
        {
            Posts posts = new Posts();
            Name _name = worker.ReturnName();
            string _post = worker.ReturnPost();
            posts.Set(_name, _post);
        }
        public void Get (Name _name, string _post)
        {
            Posts posts = new Posts();
            posts.Set(_name, _post);
        }
        public void Print ()
        {
            nameP.Print();
            Console.WriteLine($"Должность: {postP}");
        }
        private Name nameP
        {
            set
            {
                _ = nameP;
            }
            get => nameP;
        }
        private string postP
        {
            set
            {
                postP = value;
            }
            get
            {
                return postP;
            }
        }

    }
}

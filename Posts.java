package com.company;

import java.util.Scanner;

public class Posts extends Workers
{
    Name name;
    String post;
    public Posts () {};
    public  Posts Set (Name _name, String _post)
    {
        Posts post = this;
        this.name = _name;
        this.post = _post;
        return post;
    }
    public void GetFromWorker (Workers worker)
    {
        Posts post = new Posts();
        Name _name = worker.ReturnName(worker);
        String _post = worker.ReturnPost(worker);
        post.Set(_name, _post);
    }
    public void Get (Name _name)
    {
        Posts post = new Posts();
        String _post;
        Scanner in = new Scanner (System.in);
        System.out.println("Введите должность сотрудника: ");
        _post = in.nextLine();
        post.Set(_name, _post);
    }
    public void Print ()
    {
        System.out.printf("ФИО: %s %s %s\n Должность: %s", name.lastName, name.name, name.patronymic, post);
    }
}

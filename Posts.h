#include "Workers.h"

#pragma once
class Posts : public Workers
{
private:
	Name name;
	std::string post;
public:
    Posts Set(Name _name, string _post)
    {
        Posts posts;
        this->name = _name;
        this->post = _post;
        return posts;
    }
    void GetPostsFromWorker(Workers worker)
    {
        Posts posts;
        Name _name = worker.ReturnName(worker);
        string _post = worker.ReturnPost(worker);
        posts.Set(_name, _post);
    }
    void Get(Name _name)
    {
        Posts posts;
        cout << "Введите должность: ";
        std::string _post;
        cin >> _post;
        posts.Set(_name, _post);
    }
    void Print(Posts posts)
    {
        posts.PrintName();
        cout << "Должность: " << posts.post;
    }
};


using System;
using System.Collections;
using System.Collections.Generic;

// Завдання 1: Клас "Океанаріум"
class Oceanarium : IEnumerable<SeaCreature>
{
    private List<SeaCreature> creatures = new List<SeaCreature>();

    public void AddCreature(SeaCreature creature)
    {
        creatures.Add(creature);
    }

    public IEnumerator<SeaCreature> GetEnumerator()
    {
        return creatures.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

class SeaCreature
{
    public string Name { get; set; }

    public SeaCreature(string name)
    {
        Name = name;
    }
}

// Завдання 2: Клас "Футбольна Команда"
class FootballTeam : IEnumerable<Player>
{
    private List<Player> players = new List<Player>();

    public void AddPlayer(Player player)
    {
        players.Add(player);
    }

    public IEnumerator<Player> GetEnumerator()
    {
        return players.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

class Player
{
    public string Name { get; set; }

    public Player(string name)
    {
        Name = name;
    }
}

// Завдання 3: Клас "Кафе"
class Cafe : IEnumerable<Employee>
{
    private List<Employee> employees = new List<Employee>();

    public void AddEmployee(Employee employee)
    {
        employees.Add(employee);
    }

    public IEnumerator<Employee> GetEnumerator()
    {
        return employees.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

class Employee
{
    public string Name { get; set; }

    public Employee(string name)
    {
        Name = name;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Тестування ітераторів за допомогою foreach

        Oceanarium oceanarium = new Oceanarium();
        oceanarium.AddCreature(new SeaCreature("Дельфін"));
        oceanarium.AddCreature(new SeaCreature("Акула"));
        oceanarium.AddCreature(new SeaCreature("Кит"));

        Console.WriteLine("Мешканці океанаріуму:");
        foreach (var creature in oceanarium)
        {
            Console.WriteLine(creature.Name);
        }

        FootballTeam team = new FootballTeam();
        team.AddPlayer(new Player("Роналдо"));
        team.AddPlayer(new Player("Мессі"));
        team.AddPlayer(new Player("Неймар"));

        Console.WriteLine("\nГравці футбольної команди:");
        foreach (var player in team)
        {
            Console.WriteLine(player.Name);
        }

        Cafe cafe = new Cafe();
        cafe.AddEmployee(new Employee("Олег"));
        cafe.AddEmployee(new Employee("Анна"));
        cafe.AddEmployee(new Employee("Ірина"));

        Console.WriteLine("\nПрацівники кафе:");
        foreach (var employee in cafe)
        {
            Console.WriteLine(employee.Name);
        }
    }
}

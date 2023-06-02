using System;

public class Person
{
    // Atributos
    private string name;
    private string cpf;
    private string sex;
    private int age;
    private double height;
    private double weight;

    // Metodo construtor
    public Person(string name, string cpf, string sex, int age, double height, double weight) 
    {
        // Setar dados
        this.name = name;
        this.cpf = cpf;
        this.sex = sex;
        this.age = age;
        this.height = height;
        this.weight = weight;
    }

    // Metodos
    public (double, string, int) CalcIMC()
    {
        // Variaveis
        double imc = weight / Math.Pow(height, 2);
        string classification = "";
        int degree = 0;

        // Verificar indice de massa corporal
        if (imc < 18.5) { classification = "lean"; degree = 0; }
        else if (imc <= 24.9) { classification = "normal"; degree = 0; }
        else if (imc <= 29.9) { classification = "overweight"; degree = 1; }
        else if (imc <= 39.9) { classification = "obese"; degree = 2; }
        else if (imc > 40) { classification = "severe obesity"; degree = 3; }

        // Return items
        return (imc, classification, degree);
    }

    // Gets
    public string Getname() { return name; }
    public string GetCpf() { return cpf; }
    public string GetSex() { return sex; }
    public double GetHeight() { return height; }
    public double GetWeight() { return weight; }
    public int GetAge() { return age; }

    // Sets
}
# DotNetStarter - Mob programming template
Mob programming is a software development approach where the whole team works on the same thing at the same time, in the same space, and at the same computer. It is similar to pair programming, where two people collaborate with lone keyboard, and Mob Programming extends the collaboration to everyone on the team.

## Roles
We follow the driver/navigator style of work, originating as pair programming technique. We rotate driver every 10 minutes.

## Driver
The driver sits at the keyboard types in the code.

The driver listens to the navigators and focuses on translating ideas into code, asking questions as needed.

## Navigator(s) and Researcher(s)
The main work is Navigators “thinking , describing, discussing, and steering” what we are designing/developing. The coding done by the Driver is simply the mechanics of getting actual code into the computer. The Driver is also often involved in the discussions, but her main job is to translate the ideas into code.

## Getting started
1. Download and install [dotnet core](https://www.microsoft.com/net/core)
1. 
```shell
mkdir mob_programming
cd mob_programming
git clone https://github.com/jesperoastrom/DotNetStarter.git .
git remote remove origin
dotnet restore App App.Tests
```

## Building the application
```shell
dotnet build App App.Tests
```

## Running the tests
```shell
dotnet test App.Tests
```

## References
[Mob programming](http://www.nljug.org/databasejava/mob-programming/)

[Mob programming basics](http://mobprogramming.org/mob-programming-basics/)

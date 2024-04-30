# MySkileton
classDiagram
    class ITarget {
        <<interface>>
        +int Health
        +void TakeAttack(int attackPoints)
        +int GiveExperience()
        +bool IsDead()
    }
    class IWeapon {
        <<interface>>
        +int AttackPoints
        +int DurabilityPoints
        +void Attack(ITarget target)
    }
    class Dummy {
        -int health
        -int experience
        +Dummy(int health, int experience)
        +int Health
        +void TakeAttack(int attackPoints)
        +int GiveExperience()
        +bool IsDead()
    }
    class Axe {
        -int attackPoints
        -int durabilityPoints
        +Axe(int attack, int durability)
        +int AttackPoints
        +int DurabilityPoints
        +void Attack(ITarget target)
    }
    class Hero {
        -string name
        -int experience
        -IWeapon weapon
        +Hero(string name, IWeapon weapon)
        +string Name
        +int Experience
        +IWeapon Weapon
        +void Attack(ITarget target)
    }
    ITarget <|.. Dummy
    IWeapon <|.. Axe
    Hero *-- IWeapon
    Hero *-- ITarget

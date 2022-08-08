

namespace RPGcharactersTests;

public class CharacterStatsAndLevelTest
{
    [Fact]
    public void Create_LevelOneCharacter()
    {
        Warrior warrior = new(name: "Hercules", level: 1);
        Assert.True(warrior.Level == 1);
    }

    [Fact]
    public void Create_LevelTwoCharacter()
    {
        Warrior warrior = new(name: "Hercules", level: 2);
        Assert.True(warrior.Level == 2);
    }

    [Fact]
    public void Check_LevelOneWarrior_BaseStats()
    {
        int strength = 5, dexterity = 2, intelligence = 1;
        Warrior warrior = new(name: "Hercules", level: 1);

        int[] expected = { strength, dexterity, intelligence };
        int[] actual = { warrior.Strength, warrior.Dexterity, warrior.Intelligence };

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Check_LevelOneMage_BaseStats()
    {
        int strength = 1, dexterity = 1, intelligence = 8;
        Mage mage = new(name: "Maggie", level: 1);

        int[] expected = { strength, dexterity, intelligence };
        int[] actual = { mage.Strength, mage.Dexterity, mage.Intelligence };

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Check_LevelOneRanger_BaseStats()
    {
        int strength = 1, dexterity = 7, intelligence = 1;
        Ranger ranger = new(name: "Robert", level: 1);

        int[] expected = { strength, dexterity, intelligence };
        int[] actual = { ranger.Strength, ranger.Dexterity, ranger.Intelligence };

        Assert.Equal(expected, actual);
    }
    [Fact]
    public void Check_LevelOneRogue_BaseStats()
    {
        int strength = 2, dexterity = 6, intelligence = 1;
        Rogue rogue = new(name: "Bob", level: 1);

        int[] expected = { strength, dexterity, intelligence };
        int[] actual = { rogue.Strength, rogue.Dexterity, rogue.Intelligence };

        Assert.Equal(expected, actual);
    }
    [Fact]
    public void LevelUp_LevelTwoWarrior_StatsIncrease()
    {
        int strength = 8, dexterity = 4, intelligence = 2;
        Warrior warrior = new(name: "Hercules", level: 2);

        int[] expected = { strength, dexterity, intelligence };
        int[] actual = { warrior.Strength, warrior.Dexterity, warrior.Intelligence };

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void LevelUp_LevelTwoMage_StatsIncreased()
    {
        int strength = 2, dexterity = 2, intelligence = 13;
        Mage mage = new(name: "Maggie", level: 2);

        int[] expected = { strength, dexterity, intelligence };
        int[] actual = { mage.Strength, mage.Dexterity, mage.Intelligence };

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void LevelUp_LevelTwoRanger_StatsIncreased()
    {
        int strength = 2, dexterity = 12, intelligence = 2;
        Ranger ranger = new(name: "Robert", level: 2);

        int[] expected = { strength, dexterity, intelligence };
        int[] actual = { ranger.Strength, ranger.Dexterity, ranger.Intelligence };

        Assert.Equal(expected, actual);
    }
    [Fact]
    public void LevelUp_LevelTwoRogue_StatsIncreased()
    {
        int strength = 3, dexterity = 10, intelligence = 2;
        Rogue rogue = new(name: "Bob", level: 2);

        int[] expected = { strength, dexterity, intelligence };
        int[] actual = { rogue.Strength, rogue.Dexterity, rogue.Intelligence };

        Assert.Equal(expected, actual);
    }
}
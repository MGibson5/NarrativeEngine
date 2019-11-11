using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    [SerializeField] private string Name;
    [SerializeField] private int Wealth;
    [SerializeField] private int PlayerOpinion;
    [SerializeField] private string Role;
    [SerializeField] private int StartingAmountOfTraits;
    [SerializeField] private List <BaseTrait> Traits;

    [Header("Skills")]
    //skills
    [SerializeField] int StartingSkillPoints;
    [Space(10)] // 10 pixels of spacing here.

    [SerializeField] int Strength = 3;
    [SerializeField] int Agility = 3;
    [SerializeField] int Inteligence = 3;
    [SerializeField] int Charisma = 3;
    [SerializeField] int Cunning = 3;

    //Define Enum
    public enum Passion {Aquire, Destroy, Faction, Explore, Person};

    [SerializeField] private Passion Passion1;
    [SerializeField] private Passion Passion2;
    [SerializeField] private Passion Passion3;

    //managers/generators
    private CharNameGenerator NameGenerator;
    private TraitManager TraitManager;



    // Start is called before the first frame update
    void Start()
    {
        Wealth = 0;
        NameGenerator = FindObjectOfType<CharNameGenerator>();
        TraitManager = FindObjectOfType<TraitManager>();

        Name = NameGenerator.GenerateName();

        PlayerOpinion = Random.Range(-2, 2); // sets starting opinion between -2, 2
        GenerateTraits();
        GenerateSkills();
        Wealth += Random.Range(3, 20);
        if(Inteligence > 0)
            Wealth *= Mathf.RoundToInt(Inteligence / 10);

    }

    void GenerateTraits()
    {
        //Generate Traits
        for (int i = 0; i < StartingAmountOfTraits; i++)
        {
            BaseTrait _tempTrait = TraitManager.GetRandomTrait();

            //Check if trait already added if so make the for look go once more to compencate
            if (!Traits.Contains(_tempTrait))
            {
                Traits.Add(_tempTrait);
                int[] _TraitEffects = _tempTrait.GetTraitEffectedStats();
                for (int j = 0; j < _TraitEffects.Length; j++)
                {
                    Debug.Log(_TraitEffects[j]);
                    if(_TraitEffects[j] != 0) //reson this is 0 is to see if value has been changed
                    {
                        if(j == 0)
                            PlayerOpinion += _TraitEffects[j];
                        else if (j == 1)
                            Strength += _TraitEffects[j];
                        else if (j == 2)
                            Agility += _TraitEffects[j];
                        else if (j == 3)
                            Inteligence += _TraitEffects[j];
                        else if (j == 4)
                            Charisma += _TraitEffects[j];
                        else if (j == 5)
                            Cunning += _TraitEffects[j];
                    }
                }
            }
            else
            {
                i--;
                Debug.Log("Trait already Added, Generating a new one");
            }
        }
    }

    void GenerateSkills()
    {
        while(StartingSkillPoints > 0)
        {
            int r1 = Random.Range(0, 4); // random no to determin starting skill
            int r2 = Random.Range(1, StartingSkillPoints);

            if (r1 == 0)
            {
                //Strength
                Strength += r2;
                StartingSkillPoints -= r2;
            }
            else if (r1 == 1)
            {
                //Agility
                Agility += r2;
                StartingSkillPoints -= r2;
            }
            else if (r1 == 2)
            {
                //Int
                Inteligence += r2;
                StartingSkillPoints -= r2;
            }
            else if (r1 == 3)
            {
                //Char
                Charisma += r2;
                StartingSkillPoints -= r2;
            }
            else if (r1 == 4)
            {
                //Cunn
                Cunning += r2;
                StartingSkillPoints -= r2;
            }
        }
    }
}

# Enum Extension
    Pacote criado para retorno de um ou todas descrições de algum Enum
    
## Install  
        
    Install-Package enum-extension

## Usage
    public enum Sex
    {
        [Description("Male M")]
        Male,

        [Description("Female F")]
        Female,

        [Description("Unisex U")]
        Unisex,
    }
    
    EnumExtension.GetEnumAsList<Sex>() //Retorna uma lista de EnumValue com os valores das descrições do Enum.
    EnumExtension.GetDescription(Sex.Male) //Retorna a descrição do Enum passado pelo paramêtro.
  
## Examples
    
    
    EnumExtension.GetEnumAsList<Sex>(); 
     
    //Retorno
    [
       { Index = 0, Description = "Male M" },
       { Index = 1, Description = "Female F" },
       { Index = 2, Description = "Unisex U" },
    ]
     
    EnumExtension.GetDescription(Sex.Male);
     
    //Retorno 
    Male M

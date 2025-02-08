using System.ComponentModel.DataAnnotations;

namespace Ordinventory.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}


/*

    Registor:- Id(Self Generated) (Unique) (Confidential), name, email, password

    Category :- name, DisplayOrder (Category API)-------> {
                                                            (Hide) Id,-->(Error)
                                                            Name,
                                                            DisplayOrder
                                                        }

    CategoryDTO :- Name, DisplayOrder (CategoryDTO API)-------> {
                                                            Name,
                                                            DisplayOrder
                                                        }
    Category :- Id, name, DisplayOrder


    CategoryDTO :- 
        category.Name = Name, category.DisplayOrder = DisplayOrder

        return Ok(categoryDTO)
*/
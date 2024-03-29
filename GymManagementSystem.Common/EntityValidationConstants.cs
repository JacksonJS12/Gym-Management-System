namespace GymManagementSystem.Common
{
    public class EntityValidationConstants
    {
        public class User
        {
            public const int PhoneNumberMìnLength = 10;
            public const int PhoneNumberMaxLength = 17;

            public const int FirstNameMinLength = 1;
            public const int FirstNameMaxLength = 15;

            public const int LastNameMinLength = 1;
            public const int LastNameMaxLength = 15;
        }

        public class GymEquipment
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 30;

            public const int DescriptionMinLength = 10;
            public const int DescriptionMaxLength = 200;
        }
    }
}

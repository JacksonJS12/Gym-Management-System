namespace GymManagementSystem.Common
{
    public class EntityValidationConstants
    {
        public class GymMember
        {
            public const int PhoneNumberMìnLength = 10;
            public const int PhoneNumberMaxLength = 17;
        }

        public class GymEquipment
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 30;

            public const int DescriptionMinLength = 10;
            public const int DescriptionMaxLength = 50;
        }
    }
}

namespace Blobs.Utils
{
    internal static class ErrorMessages
    {
        internal const string InvalidCharacterName = "Character name can't be null or empty.";
        internal const string InvalidBlobDamageValue = "Blob damage can't be less than or equal to 0.";
        internal const string DeadBlobAttackError = "Invalid Operation: Dead blobs can't attack.";
        internal const string InvalidAttackDamage = "AbstractCommand damage can't be less than, or equal to 0.";
        internal const string OwnerAlreadySet = "Invalid Operation: An Owner is already set.";
        internal const string OwnerNotSet = "Invalid Operation: Owner is not set.";
        internal const string DeadBlobAttackedError = "Invalid Operation: Dead blobs cannot be attacked.";
        internal const string BehaviorIsAlreadyActive = "Invalid Operation: Behavior is already active.";
        internal const string BehaviorWasAlreadyUsed = "Invalid Operation: Behavior was already used once.";
        internal const string BehaviorNotActive = "Invalid Operation: Behavior is not active.";
        internal const string TakenDamageMustBePositive = "Taken Damage value must be positive.";
        internal const string HealthBonusMustBePositive = "Health Bonus valud must be positive.";
        internal const string BehaviorNotSupported = "No such behavior class.";
        internal const string AttackIsNotSupported = "No such attack class.";
        internal const string HealthValueIsInvalid = "Invalid Blob Health value.";
        internal const string DamageValueIsInvalid = "Invalid Blob Damage value.";
        internal const string InvalidParamsLength = "Command Params are not set correctly.";
        internal const string InvalidCommand = "The specified command is not implemented.";
    }
}

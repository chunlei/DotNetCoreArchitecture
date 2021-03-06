using DotNetCoreArchitecture.Model;

namespace DotNetCoreArchitecture.Domain
{
    public static class UserLogEntityFactory
    {
        public static UserLogEntity Create(AddUserLogModel addUserLogModel)
        {
            return new UserLogEntity(0, addUserLogModel.UserId, addUserLogModel.LogType);
        }
    }
}

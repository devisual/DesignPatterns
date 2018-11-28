namespace Visitor
{
    class ExternalUser : User
    {
        public override void Accept(Module module)
        {
            module.VisitUser(this);
        }
    }
}
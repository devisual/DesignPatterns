namespace Visitor
{
    class StandardUser : User
    {
        public override void Accept(Module module)
        {
            module.VisitUser(this);
        }
    }
}
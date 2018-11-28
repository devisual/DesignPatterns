namespace Visitor
{
    class SuperUser : User
    {
        public override void Accept(Module module)
        {
            module.VisitUser(this);
        }
    }
}
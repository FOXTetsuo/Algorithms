namespace AD
{
    //
    // This class offers static methods to create datastructures.
    // It is called by unit tests.
    //
    public partial class DSBuilder
    {
        public static IFirstChildNextSibling<string> CreateFirstChildNextSibling_Empty ()
        {
            FirstChildNextSibling<string> tree = new FirstChildNextSibling<string> ();
            return tree;
        }

        public static IFirstChildNextSibling<string> CreateFirstChildNextSibling_Small ()
        {
            FirstChildNextSibling<string> tree = new FirstChildNextSibling<string> ();

            FirstChildNextSiblingNode<string> e = new FirstChildNextSiblingNode<string>("e");
            FirstChildNextSiblingNode<string> d = new FirstChildNextSiblingNode<string>("d");
            FirstChildNextSiblingNode<string> c = new FirstChildNextSiblingNode<string>("c", null, d);
            FirstChildNextSiblingNode<string> b = new FirstChildNextSiblingNode<string>("b", e, c);
            FirstChildNextSiblingNode<string> a = new FirstChildNextSiblingNode<string>("a", b, null);

            tree.root = a;

            return tree;
        }

        public static IFirstChildNextSibling<string> CreateFirstChildNextSibling_18_3 ()
        {
            throw new System.NotImplementedException();
        }
    }
}
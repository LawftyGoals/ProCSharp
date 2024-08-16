
namespace CustomInterfaces;
public abstract class CloneableType {
    /* only derived types can support this
     * "polymophic interface". Classes in other
     * hierarchies have no access to this abstract
     * member. */
    public abstract object Clone();

}

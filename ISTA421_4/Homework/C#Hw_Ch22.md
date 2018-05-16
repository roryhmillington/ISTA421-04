1. Explain the diﬀerence between the concepts of associativity and precedence.

	Each operator has a precedence. For example, the * operator has a higher precedence than the + operator. This means that the expression a + b * c is the same as a + (b * c).  

	Each operator also has an associativity that defines whether the operator evaluates from left to right or from right to left. For example, the = operator is right-associative (it evaluates from right to left), so a = b = c is the same as a = (b = c).

2. Explain the diﬀerence between the concepts of binary and unary operators.

	 A unary operator is an operator that has just one operand. For example, the increment operator (++) is a unary operator.  

	A binary operator is an operator that has two operands. For example, the multiplication operator (*) is a binary operator.


3. List four constraints imposed by C# with respect to operator overloading.

	You cannot change the precedence and associativity of an operator. Precedence and associativity are based on the operator symbol (for example, +) and not on the type (for example, int) on which the operator symbol is being used. Hence, the expression a + b * c is always the same as a + (b * c) regardless of the types of a, b, and c.  

	You cannot change the multiplicity (the number of operands) of an operator. For example, * (the symbol for multiplication) is a binary operator. If you declare a * operator for your own type, it must be a binary operator.  

	You cannot invent new operator symbols. For example, you can’t create an operator symbol such as ** for raising one number to the power of another number. You’d have to define a method to do that.  

	You can’t change the meaning of operators when they are applied to built-in types. For example, the expression 1 + 2 has a predefined meaning, and you’re not allowed to override this meaning. If you could do this, things would be too complicated.  

	There are some operator symbols that you can’t overload. For example, you can’t overload the dot (.) operator, which indicates access to a class member. Again, if you could do this, it would lead to unnecessary complexity.


4. What is the syntax for overloading operators? Discuss access, scope, return value types, and parameter types and multiplicity.

	struct Hour
	{
    public Hour(int initialValue)
    {
        this.value = initialValue;
    }
    public static Hour operator +(Hour lhs, Hour rhs)
    {
        return new Hour(lhs.value + rhs.value);
    }
    ...
    private int value;
	}

5. What are symmetric overloaded binary operators and how do they diﬀer from non-symmetric overloaded binary operators?

	

6. Can you overload compound assignment operators? If so, please state how you do so. If not, explain why not.

	NO

7. What is the diﬀerence between overloading increment and decrement operators for value types and reference types?

	With C#, you can declare your own version of the increment (++) and decrement (––) operators. The usual rules apply when declaring these operators: they must be public, they must be static, and they must be unary (they can take only a single parameter).

	The increment and decrement operators are unique in that they can be usedWhen should you declare a conversion operator as explicit or implicit? If a conversion is always safe, does not run the risk of losing information, and cannot throw an exception, it can be defined as an implicit conversion. Otherwise, it should be declared as an explicit conversion. Converting from an Hour to an int is always safe—every Hour has a corresponding int value—so it makes sense for it to be implicit.

  	in prefix and postfiWhen should you declare a conversion operator as explicit or implicit? If a conversion is always safe, does not run the risk of losing information, and cannot throw an exception, it can be defined as an implicit conversion. Otherwise, it should be declared as an explicit conversion. Converting from an Hour to an int is always safe—every Hour has a corresponding int value—so it makes sense for it to be implicit.


8. Why do we overload some operators in pairs?

	Some operators naturally come in pairs. For example, if you can compare two Hour values by using the != operator, you would expect to be able to also compare two Hour values by using the == operator. The C# compiler enforces this very reasonable expectation by insisting that if you define either operator == or operator !=, you must define them both. This neither-or-both rule also applies to the < and > operators and the <= and >= operators. The C# compiler does not write any of these operator partners for you. You must write them all explicitly yourself, regardless of how obvious they might seem.


9. What is the diﬀerence between widening conversion and narrowing conversion?

	An implicit conversion is sometimes called a widening conversion because the result is wider than the original value—it contains at least as much information as the original value, and nothing is lost.

	An explicit conversion is sometimes called a narrowing conversion because the result is narrower than the original value (that is, it can contain less information) and can throw an OverflowException exception if the resulting value is out of the range of the target type.


10. What is the diﬀerence between explicit conversion and implicit conversion?

	When should you declare a conversion operator as explicit or implicit? If a conversion is always safe, does not run the risk of losing information, and cannot throw an exception, it can be defined as an implicit conversion. Otherwise, it should be declared as an explicit conversion.


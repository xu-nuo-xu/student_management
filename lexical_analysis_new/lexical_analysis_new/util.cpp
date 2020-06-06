#include "pch.h"
#include "global.h"
#include "util.h"
#include "lexical_anaylsis.h"
/* Function newStmtNode creates a new statement
 * node for syntax tree construction
 */
TreeNode * newStmtNode(StmtKind kind)
{
	TreeNode * t = (TreeNode *)malloc(sizeof(TreeNode));
	int i;
	if (t == NULL)
		printf("Out of memory error at line %d\n", lineno);
	else {
		for (i = 0;i < MAXCHILDREN;i++) t->child[i] = NULL;
		t->sibling = NULL;
		t->nodekind = StmtK;
		t->kind.stmt = kind;
		t->lineno = lineno;
	}
	return t;
}

/* Function newExpNode creates a new expression
 * node for syntax tree construction
 */
TreeNode * newExpNode(ExpKind kind)
{
	TreeNode * t = (TreeNode *)malloc(sizeof(TreeNode));
	int i;
	if (t == NULL)
		printf("Out of memory error at line %d\n", lineno);
	else {
		for (i = 0;i < MAXCHILDREN;i++) t->child[i] = NULL;
		t->sibling = NULL;
		t->nodekind = ExpK;
		t->kind.exp = kind;
		t->lineno = lineno;
		t->PLACE = -1;
	}
	return t;
}
/* Variable indentno is used by printTree to
 * store current number of spaces to indent
 */
static int indentno = 0;

/* macros to increase/decrease indentation */
#define INDENT indentno+=2
#define UNINDENT indentno-=2

/* printSpaces indents by printing spaces */
static void printSpaces(void)
{
	int i;
	for (i = 0;i < indentno;i++)
		printf(" ");
}
/* procedure printTree prints a syntax tree to the
 * listing file using indentation to indicate subtrees
 */
void printTree(TreeNode * tree)
{
	int i;
	INDENT;
	while (tree != NULL) {
		printSpaces();
		if (tree->nodekind == StmtK)
		{
			switch (tree->kind.stmt) {
			case IfK:
				printf( "If\n");
				break;
			case AssignK:
				printf("Assign to: %s\n", tree->attr.name);
				break;
			case WhileK:
				printf("While\n");
				break;
			case CompK:
				printf("begin_end\n");
				break;
			case VarDefK:
				printf("VarDef\n");
				break;
			default:
				printf("Unknown StmtNode kind\n");
				break;
			}
		}
		else if (tree->nodekind == ExpK)
		{
			switch (tree->kind.exp) {
			case OpK:
				printf("Op: ");
				printf("%s\0",tree->attr.name);
				break;
			case intNumK:
				printf("Num: %d\n", tree->attr.val);
				break;
			case realNumK:
				printf("Num: %.2lf\n", tree->attr.vald);
				break;
			case IdK:
				printf("Id: %s\n", tree->attr.name);
				break;
			case IntK:
				printf("Integer\n");
				break;
			case RealK:
				printf("Reald\n");
				break;
			default:
				printf("Unknown ExpNode kind\n");
				break;
			}
		}
		else printf("Unknown node kind\n");
		for (i = 0;i < MAXCHILDREN;i++)
		{
			if (tree->child[i] != NULL)
			{
				printTree(tree->child[i]);
			}
		}
			
		tree = tree->sibling;
	}
	UNINDENT;
}
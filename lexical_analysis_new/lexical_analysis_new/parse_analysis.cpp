#include "pch.h"
#include "iostream"
#include "stdio.h"
#include "stdlib.h"
#include "string.h"
#include "lexical_anaylsis.h"
#include "parse_analysis.h"
#include "util.h"

using namespace std;
extern int parse_point;		//指向当前识别的result_token
extern struct token result_token[1000];	//词法分析中的识别token表
char Iden_state_list[200][50];	//变量声明表
int free_Iden_state_list = 0;
int quaternary_free = 0;
struct quaternary quaternary[100] = { 0 };
int tmp = 0;
/*******************************递归下降文法函数定义*****************************/
int match(const char token[])
{
	if (strcmp(token, result_token[parse_point].name)==0)	//终结符匹配成功，指针后移
	{
		parse_point++;
		lineno = result_token[parse_point].row_num;
		return 1;
	}
	else
	{
		return 0;
	}
}
void wrong_sentence()
{
	printf("Error: this is a wrong program!\n");
	printf("locate in row:%d\n", result_token[parse_point].row_num);
	exit(0);
}
TreeNode * Expr()
{
	if (match("("))		//'(' Expr ')' Expr_
	{
		TreeNode * t = Expr();
		if (match(")"))
		{
			//do nothing
		}
		else
		{
			wrong_sentence();
		}
		TreeNode * p = Expr_();
		if (p != NULL)
		{
			p->child[0] = t;
			generate_quaternary(p->attr.name, Iden_state_list[p->child[0]->PLACE], Iden_state_list[p->child[1]->PLACE], Iden_state_list[p->PLACE]);
			return p;
									//p->child[1]在Expr_中进行设定
		}							//这里存在一个优先级问题，拿(5+6)+7做例子，第一个+是Expr的返回值，第二个+是
		else						//Expr_的返回值，而括号中的应当在树的相对低层做孩子
		{
			//generate_quaternary(t->attr.name, Iden_state_list[t->child[0]->PLACE], Iden_state_list[t->child[1]->PLACE], Iden_state_list[t->PLACE]);
			return t;
		}
								

	}
	else if (result_token[parse_point].type == 100)	//Iden Expr_
	{
		int PLACE = find_Iden();
		if (find_Iden() == 0)	//变量是否声明检测
		{
			printf("Error: this var : %s isn't stated, row num: %d\n", result_token[parse_point].name, result_token[parse_point].row_num);	//使用未声明变量错误处理
			exit(0);
		}
		TreeNode * t = newExpNode(IdK);
		strcpy(t->attr.name, result_token[parse_point].name);
		t->PLACE = PLACE;	//指向符号表对应项的指针
		parse_point++;
		TreeNode * p = Expr_();
		if (p != NULL)
		{
			p->child[0] = t;	//p->child[1]在Expr_中进行设定
			generate_quaternary(p->attr.name, Iden_state_list[p->child[0]->PLACE], Iden_state_list[p->child[1]->PLACE], Iden_state_list[p->PLACE]);
			return p;
		}
		else return t;
	}
	else if(result_token[parse_point].type == 98)	//IntNo Expr_
	{
		TreeNode * t = newExpNode(intNumK);
		t->attr.val = atoi(result_token[parse_point].name);
		t->PLACE = free_Iden_state_list;	//专为数字设定,此时不代表指针
		strcpy(Iden_state_list[free_Iden_state_list++], result_token[parse_point].name);
		parse_point++;
		TreeNode * p = Expr_();
		if (p != NULL)
		{
			p->child[0] = t;	//p->child[1]在Expr_中进行设定
			generate_quaternary(p->attr.name, Iden_state_list[p->child[0]->PLACE], Iden_state_list[p->child[1]->PLACE], Iden_state_list[p->PLACE]);
			return p;
		}
		else return t;
	}
	else if (result_token[parse_point].type == 99)	//RealNo Expr_
	{
		TreeNode * t = newExpNode(realNumK);
		char tmp[50];
		strcpy(tmp,result_token[parse_point].name);
		t->attr.vald = atof(tmp);
		t->PLACE = free_Iden_state_list;
		strcpy(Iden_state_list[free_Iden_state_list++], result_token[parse_point].name);
		parse_point++;
		TreeNode * p = Expr_();
		if (p != NULL)
		{
			p->child[0] = t;	//p->child[1]在Expr_中进行设定
			generate_quaternary(p->attr.name, Iden_state_list[p->child[0]->PLACE], Iden_state_list[p->child[1]->PLACE], Iden_state_list[p->PLACE]);
			return p;
		}
		else return t;
	}
}
TreeNode * Expr_()
{
	if (match("+"))	//'+' Expr Expr_
	{
		TreeNode * t = newExpNode(OpK);
		strcpy(t->attr.name, "+");
		t->PLACE = generate_tmp();
		TreeNode * p = Expr();
		Expr_();	//********************感觉每次都是空，暂定
		t->child[1] = p;
		return t;
	}
	else if (match("-"))	//'-' Expr Expr_
	{
		TreeNode * t = newExpNode(OpK);
		strcpy(t->attr.name, "-");
		t->PLACE = generate_tmp();
		TreeNode * p = Expr();
		Expr_();	//********************感觉每次都是空，暂定
		t->child[1] = p;
		return t;
	}
	else if (match("*"))	//'*' Expr Expr_
	{
		TreeNode * t = newExpNode(OpK);
		strcpy(t->attr.name, "*");
		t->PLACE = generate_tmp();
		TreeNode * p = Expr();
		Expr_();	//********************感觉每次都是空，暂定
		t->child[1] = p;
		return t;
	}
	else if (match("/"))	//'/' Expr Expr_
	{
		TreeNode * t = newExpNode(OpK);
		strcpy(t->attr.name, "/");
		t->PLACE = generate_tmp();
		TreeNode * p = Expr();
		Expr_();	//********************感觉每次都是空，暂定
		t->child[1] = p;
		return t;
	}
	else if (match(">"))	//'>' Expr Expr_
	{
		TreeNode * t = newExpNode(OpK);
		strcpy(t->attr.name, ">");
		t->PLACE = generate_tmp();
		TreeNode * p = Expr();
		Expr_();	//********************感觉每次都是空，暂定
		t->child[1] = p;
		return t;
	}
	else if (match("<"))	//'<' Expr Expr_
	{
		TreeNode * t = newExpNode(OpK);
		strcpy(t->attr.name, "<");
		t->PLACE = generate_tmp();
		TreeNode * p = Expr();
		Expr_();	//********************感觉每次都是空，暂定
		t->child[1] = p;
		return t;
	}
	else if (match(">="))	//'>=' Expr Expr_
	{
		TreeNode * t = newExpNode(OpK);
		strcpy(t->attr.name, ">=");
		t->PLACE = generate_tmp();
		TreeNode * p = Expr();
		Expr_();	//********************感觉每次都是空，暂定
		t->child[1] = p;
		return t;
	}
	else if (match("<="))	//'<=' Expr Expr_
	{
		TreeNode * t = newExpNode(OpK);
		strcpy(t->attr.name, "<=");
		t->PLACE = generate_tmp();
		TreeNode * p = Expr();
		Expr_();	//********************感觉每次都是空，暂定
		t->child[1] = p;
		return t;
	}
	else if (match("<>"))	//'<>' Expr Expr_
	{
		TreeNode * t = newExpNode(OpK);
		strcpy(t->attr.name, "<>");
		t->PLACE = generate_tmp();
		TreeNode * p = Expr();
		Expr_();	//********************感觉每次都是空，暂定
		t->child[1] = p;
		return t;
	}
	else if (match("="))	//'=' Expr Expr_
	{
		TreeNode * t = newExpNode(OpK);
		strcpy(t->attr.name, "=");
		t->PLACE = generate_tmp();
		TreeNode * p = Expr();
		Expr_();	//********************感觉每次都是空，暂定
		t->child[1] = p;
		return t;
	}
	else if (match("and"))	//'and' Expr Expr_
	{
		TreeNode * t = newExpNode(OpK);
		strcpy(t->attr.name, "and");
		t->PLACE = generate_tmp();
		TreeNode * p = Expr();
		Expr_();	//********************感觉每次都是空，暂定
		t->child[1] = p;
		return t;
	}
	else if (match("or"))	//'or' Expr Expr_
	{
	TreeNode * t = newExpNode(OpK);
	strcpy(t->attr.name, "or");
	t->PLACE = generate_tmp();
	TreeNode * p = Expr();
	Expr_();	//********************感觉每次都是空，暂定
	t->child[1] = p;
	return t;
	}
}
TreeNode * Type()
{
	TreeNode *s;
	if (match("integer"))	//"integer"
	{
		s = newExpNode(IntK);
		return s;
	}
	else if (match("reald"))	//"reald"
	{
		s = newExpNode(RealK);
		return s;
	}
	else
	{
		wrong_sentence();
	}
	return NULL;
}
TreeNode * Statement()
{
	TreeNode *t, *q, *p, *s = NULL;
	if (result_token[parse_point].type == 100)	//AssignState
	{
		s = newStmtNode(AssignK);
		strcpy(s->attr.name, result_token[parse_point].name);
		t = AssignState();
		if (t != NULL)
		{
			s->child[0] = t;
			return s;
		}
		return NULL;
	}
	else if (match("if"))	//IBT Statement Statement’
	{
		s = newStmtNode(IfK);
		parse_point--;	//在IBT中在重新判断"if"，毕竟现在只是个非终结符
		t = IBT();
		q = Statement();
		s->child[0] = t;	//test部分
		s->child[1] = q;	//then部分
		p = Statement_();
		if (p != NULL)
		{
			s->child[2] = p;	//else部分
		}
		return s;
	}
	else if (match("while"))	//WBD Statement
	{
		parse_point--;
		s = newStmtNode(WhileK);
		t = WBD();			//test部分
		q = Statement();	//do部分
		if (t != NULL && q != NULL)
		{
			s->child[0] = t;
			s->child[1] = q;
			return s;
		}
		return NULL;
	}
	else if (match("begin"))	//CompState
	{
		parse_point--;
		s = newStmtNode(CompK);
		t = CompState();
		if (t != NULL)
		{
			s->child[0] = t;
			return s;
		}
	}
	return NULL;
}
TreeNode * Statement_()
{
	if (match("else"))			//"else" Statement
	{
		TreeNode * s = Statement();
		return s;
	}
	return NULL;
}
 TreeNode * IBT()
{
	if (match("if"))		//"if" Expr "then"
	{
		TreeNode *s = Expr();
		if (match("then") && s!=NULL)
		{
			return s;
		}
		else
		{
			wrong_sentence();
		}
	}
	else
	{
		wrong_sentence();
	}
	return NULL;
}
TreeNode * WBD()
{
	if (match("while"))		//"while" Expr "do"
	{
		TreeNode *s = Expr();
		if (match("do") && s != NULL)
		{
			return s;
		}
		else
		{
			wrong_sentence();
		}
	}
	else
	{
		wrong_sentence();
	}
	return NULL;
}
TreeNode * CompState()
{
	if (match("begin"))		//"begin" StateList "end"
	{
		TreeNode *s = StateList();
		if (match("end") && s!=NULL)
		{
			return s;
		}
		else
		{
			wrong_sentence();
		}
	}
	else
	{
		wrong_sentence();
	}
	return NULL;
}
int find_Iden()
{
	if (result_token[parse_point].array_element == 1)	//数组元素不在语法分析中检测，在词法分析中已经检测完毕
	{
		return 1;
	}
	for (int i = 0;i < free_Iden_state_list;i++)
	{
		if (strcmp(result_token[parse_point].name, Iden_state_list[i]) == 0)
		{
			//printf("this var is stated\n");		//使用了已经声明的变量可以不输出
			return i;
		}
	}
	return 0;
	
}

TreeNode * AssignState()
{
	int PLACE;
	PLACE = find_Iden();
	if (result_token[parse_point].type == 100)	//Iden ':=' Expr	
	{
		if (find_Iden() == 0)
		{
			printf("Error: this var : %s isn't stated, row num: %d\n", result_token[parse_point].name, result_token[parse_point].row_num);	//使用未声明变量错误处理
			exit(0);
		}
		parse_point++;
		if (match(":="))
		{
			TreeNode *s = Expr();
			if (s != NULL)
			{
				char assign[5] = ":=";
				char zero[5] = "0";
				generate_quaternary(assign, Iden_state_list[s->PLACE], zero, Iden_state_list[PLACE]);
				return s;
			}
		}
		else
		{
			wrong_sentence();
		}
	}
	else
	{
		wrong_sentence();
	}
	return NULL;
}
TreeNode * StateList()
{
	TreeNode *s = Statement();	//Statement StateList_
	TreeNode *t = StateList_();
	if (s != NULL & t != NULL)
	{
		s->sibling = t;	//并列关系用sibling
	}
	if (s != NULL)
	{
		return s;
	}
	return NULL;
}
TreeNode * StateList_()
{
	if (match(";"))	//';' Statement StateList_
	{
		TreeNode *s = Statement();
		TreeNode *t = StateList_();
		if (s != NULL & t != NULL)
		{
			s->sibling = t;	//并列关系用sibling
		}
		if (s != NULL)
		{
			return s;
		}
	}
	return NULL;
}
TreeNode * VarList()
{
	if (result_token[parse_point].type == 100)	//Iden VarList_
	{
		/*if (find_Iden() == 1)	//重复定义检测，当成Error处理
		{
			printf("Error: repeat state var: %s , row num: %d\n", result_token[parse_point].name, result_token[parse_point].row_num);
			exit(0);
		}*/
		TreeNode *s = newExpNode(IdK);
		strcpy(s->attr.name, result_token[parse_point].name);
		strcpy(Iden_state_list[free_Iden_state_list++], result_token[parse_point].name);	//添加到变量声明表中
		parse_point++;
		TreeNode *t = VarList_();
		if (s != NULL)
		{
			if (t != NULL)
			{
				s->child[0] = t;
			}
			return s;
		}
	}
	else
	{
		wrong_sentence();
	}
	return NULL;
}
TreeNode * VarList_()
{
	if (match(","))		//',' Iden VarList_
	{
		if (result_token[parse_point].type == 100)
		{
			/*if (find_Iden() == 1)	//重复定义检测，当成Error处理
			{
				printf("Error: repeat state var: %s , row num: %d\n", result_token[parse_point].name, result_token[parse_point].row_num);
				exit(0);
			}*/
			TreeNode *s = newExpNode(IdK);
			strcpy(s->attr.name, result_token[parse_point].name);
			strcpy(Iden_state_list[free_Iden_state_list++], result_token[parse_point].name);	//添加到变量声明表中
			parse_point++;
			TreeNode *t = VarList_();
			if (s != NULL)
			{
				if (t != NULL)
				{
					s->child[0] = t;
				}
				return s;
			}
		}
		else
		{
			wrong_sentence();
		}
	}
	return NULL;
}
TreeNode * VarDefState()
{
	TreeNode *t = VarList();			//VarList ':' Type
	if (match(":"))
	{
		TreeNode *s = Type();
		if (s != NULL && t != NULL)
		{
			s->child[0] = t;
			return s;
		}
	}
	else
	{
		wrong_sentence();
	}
	return NULL;
}
TreeNode * VarDefList()
{
	TreeNode *s = VarDefState();		//VarDefState VarDefList_
	TreeNode *t = VarDefList_();
	if (s != NULL)
	{
		if (t != NULL)
		{
			s->sibling = t;
		}
		return s;
	}
	return NULL;
}
TreeNode * VarDefList_()
{
	if (match(";"))		//';' VarDefState VarDefList'|
	{
		TreeNode *s = VarDefState();
		TreeNode *t = VarDefList_();
		if (s != NULL)
		{
			if (t != NULL)
			{
				s->sibling = t;
			}
			return s;
		}
	}
	return NULL;
}
TreeNode * VarDef()
{
	if (match("var"))		//"var" VarDefList 
	{
		TreeNode *s = newStmtNode(VarDefK);
		TreeNode *t = VarDefList();
		if (s != NULL && t != NULL)
		{
			s->child[0] = t;
			return s;
		}
	}
	else
	{
		wrong_sentence();
	}
	return NULL;
}
TreeNode * SubProg()
{
	TreeNode *s = VarDef();		// VarDef CompState
	TreeNode *t = CompState();
	if (s != NULL && t != NULL)
	{
		s->sibling = t;
		return s;
	}
	return NULL;
}
TreeNode * ProgDef()		// "program" Iden ';' SubProg '.'
{
	if (match("program") && result_token[parse_point++].type == 100 && match(";"))
	{
		TreeNode *s = newExpNode(IdK);
		strcpy(s->attr.name, result_token[parse_point - 2].name);
		strcpy(Iden_state_list[free_Iden_state_list++], result_token[parse_point - 2].name);	//添加到变量声明表中
		TreeNode *t = SubProg();
		if (match(".") && s != NULL && t != NULL)
		{
			s->child[0] = t;
			return s;
		}
		else
		{
			wrong_sentence();
		}
	}
	else
	{
		wrong_sentence();
	}
	return NULL;
}

/**************************生成四元式相关函数*****************/
void generate_quaternary(char op[], char arg1[], char arg2[], char result[])
{
	strcpy(quaternary[quaternary_free].op, op);
	strcpy(quaternary[quaternary_free].arg1, arg1);
	strcpy(quaternary[quaternary_free].arg2, arg2);
	strcpy(quaternary[quaternary_free].result, result);
	quaternary_free++;
	printf("( %s , %s , %s , %s )\n", op, arg1, arg2, result);
	return;
}
int generate_tmp()	//申请一个临时变量
{
	char tmp_name[10] = "t";
	char num[5] = { 0 };
	itoa(tmp,num,10);
	strcat(tmp_name,num);
	strcpy(Iden_state_list[free_Iden_state_list++], tmp_name);
	tmp++;
	return free_Iden_state_list - 1;
}

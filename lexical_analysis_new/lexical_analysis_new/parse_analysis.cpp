#include "pch.h"
#include "iostream"
#include "stdio.h"
#include "stdlib.h"
#include "string.h"
#include "lexical_anaylsis.h"
#include "parse_analysis.h"
using namespace std;
extern int parse_point;		//指向当前识别的result_token
extern struct token result_token[1000];	//词法分析中的识别token表
char Iden_state_list[200][50];	//变量声明表
int free_Iden_state_list = 0;
/*******************************递归下降文法函数定义*****************************/
int match(const char token[])
{
	if (strcmp(token, result_token[parse_point].name)==0)	//终结符匹配成功，指针后移
	{
		parse_point++;
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
void Expr()
{
	if (match("("))		//'(' Expr ')' Expr_
	{
		Expr();
		if (match(")"))
		{
			//do nothing
		}
		else
		{
			wrong_sentence();
		}
		Expr_();
	}
	else if (result_token[parse_point].type == 100)	//Iden Expr_
	{
		if (find_Iden() == 0)	//变量是否声明检测
		{
			printf("Error: this var : %s isn't stated, row num: %d\n", result_token[parse_point].name, result_token[parse_point].row_num);	//使用未声明变量错误处理
			exit(0);
		}		
		parse_point++;
		Expr_();
	}
	else if(result_token[parse_point].type == 98)	//IntNo Expr_
	{
		parse_point++;
		Expr_();
	}
	else if (result_token[parse_point].type == 99)	//RealNo Expr_
	{
		parse_point++;
		Expr_();
	}
}
void Expr_()
{
	if (match("+"))	//'+' Expr Expr_
	{
		Expr();
		Expr_();
	}
	else if (match("-"))	//'-' Expr Expr_
	{
		Expr();
		Expr_();
	}
	else if (match("*"))	//'*' Expr Expr_
	{
		Expr();
		Expr_();
	}
	else if (match("/"))	//'/' Expr Expr_
	{
		Expr();
		Expr_();
	}
	else if (match(">"))	//'>' Expr Expr_
	{
		Expr();
		Expr_();
	}
	else if (match("<"))	//'<' Expr Expr_
	{
		Expr();
		Expr_();
	}
	else if (match(">="))	//'>=' Expr Expr_
	{
		Expr();
		Expr_();
	}
	else if (match("<="))	//'<=' Expr Expr_
	{
		Expr();
		Expr_();
	}
	else if (match("<>"))	//'<>' Expr Expr_
	{
		Expr();
		Expr_();
	}
	else if (match("="))	//'=' Expr Expr_
	{
		Expr();
		Expr_();
	}
	else if (match("and"))	//'and' Expr Expr_
	{
		Expr();
		Expr_();
	}
	else if (match("or"))	//'or' Expr Expr_
	{
		Expr();
		Expr_();
	}
}
void Type()
{
	if (match("integer"))	//"integer"
	{
		//do nothing
	}
	else if (match("reald"))	//"reald"
	{
		//do nothing
	}
	else
	{
		wrong_sentence();
	}
}
void Statement()
{
	if (result_token[parse_point].type == 100)	//AssignState
	{
		AssignState();
	}
	else if (match("if"))	//IBT Statement Statement’
	{
		parse_point--;	//在IBT中在重新判断"if"，毕竟现在只是个非终结符
		IBT();
		Statement();
		Statement_();
	}
	else if (match("while"))	//WBD Statement
	{
		parse_point--;
		WBD();
		Statement();
	}
	else if (match("begin"))	//CompState
	{
		parse_point--;
		CompState();
	}
}
void Statement_()
{
	if (match("else"))			//"else" Statement
	{
		Statement();
	}
}
void IBT()
{
	if (match("if"))		//"if" Expr "then"
	{
		Expr();
		if (match("then"))
		{
			//do nothing
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
}
void WBD()
{
	if (match("while"))		//"while" Expr "do"
	{
		Expr();
		if (match("do"))
		{
			//do nothing
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
}
void CompState()
{
	if (match("begin"))		//"begin" StateList "end"
	{
		StateList();
		if (match("end"))
		{
			//do nothing
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
			return 1;
		}
	}
	return 0;
	
}

void AssignState()
{
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
			Expr();
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
}
void StateList()
{
	Statement();	//Statement StateList_
	StateList_();
}
void StateList_()
{
	if (match(";"))	//';' Statement StateList_
	{
		Statement();
		StateList_();
	}
}
void VarList()		
{
	if (result_token[parse_point].type == 100)	//Iden VarList_
	{
		if (find_Iden() == 1)	//重复定义检测，当成Error处理
		{
			printf("Error: repeat state var: %s , row num: %d\n", result_token[parse_point].name, result_token[parse_point].row_num);
			exit(0);
		}
		strcpy(Iden_state_list[free_Iden_state_list++], result_token[parse_point].name);	//添加到变量声明表中
		parse_point++;
		VarList_();
	}
	else
	{
		wrong_sentence();
	}
}
void VarList_()
{
	if (match(","))		//',' Iden VarList_
	{
		if (result_token[parse_point].type == 100)
		{
			if (find_Iden() == 1)	//重复定义检测，当成Error处理
			{
				printf("Error: repeat state var: %s , row num: %d\n", result_token[parse_point].name, result_token[parse_point].row_num);
				exit(0);
			}
			strcpy(Iden_state_list[free_Iden_state_list++], result_token[parse_point].name);	//添加到变量声明表中
			parse_point++;
			VarList_();
		}
		else
		{
			wrong_sentence();
		}
	}
}
void VarDefState()
{
	VarList();			//VarList ':' Type
	if (match(":"))
	{
		Type();
	}
	else
	{
		wrong_sentence();
	}
}
void VarDefList()
{
	VarDefState();		//VarDefState VarDefList_
	VarDefList_();
}
void VarDefList_()
{
	if (match(";"))		//';' VarDefState VarDefList'|
	{
		VarDefState();
		VarDefList_();
	}
}
void VarDef()
{
	if (match("var"))		//"var" VarDefList 
	{
		VarDefList();
	}
	else
	{
		wrong_sentence();
	}
}
void SubProg()
{
	VarDef();		// VarDef CompState
	CompState();
}
void ProgDef()		// "program" Iden ';' SubProg '.'
{
	if (match("program") && result_token[parse_point++].type == 100 && match(";"))
	{
		strcpy(Iden_state_list[free_Iden_state_list++], result_token[parse_point - 2].name);	//添加到变量声明表中
		SubProg();
		if (match("."))
		{
			//do nothing
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
}


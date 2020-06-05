#include "pch.h"
#include "iostream"
#include "stdio.h"
#include "stdlib.h"
#include "string.h"
#include "lexical_anaylsis.h"
#include "parse_analysis.h"
#include "util.h"

using namespace std;
extern int parse_point;		//ָ��ǰʶ���result_token
extern struct token result_token[1000];	//�ʷ������е�ʶ��token��
char Iden_state_list[200][50];	//����������
int free_Iden_state_list = 0;
/*******************************�ݹ��½��ķ���������*****************************/
int match(const char token[])
{
	if (strcmp(token, result_token[parse_point].name)==0)	//�ս��ƥ��ɹ���ָ�����
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
			return p;
									//p->child[1]��Expr_�н����趨
		}							//�������һ�����ȼ����⣬��(5+6)+7�����ӣ���һ��+��Expr�ķ���ֵ���ڶ���+��
		else return t;					//Expr_�ķ���ֵ���������е�Ӧ����������ԵͲ�������

	}
	else if (result_token[parse_point].type == 100)	//Iden Expr_
	{
		if (find_Iden() == 0)	//�����Ƿ��������
		{
			printf("Error: this var : %s isn't stated, row num: %d\n", result_token[parse_point].name, result_token[parse_point].row_num);	//ʹ��δ��������������
			exit(0);
		}		
		TreeNode * t = newExpNode(IdK);
		strcpy(t->attr.name, result_token[parse_point].name);
		parse_point++;
		TreeNode * p = Expr_();
		if (p != NULL)
		{
			p->child[0] = t;	//p->child[1]��Expr_�н����趨
			return p;
		}
		else return t;
	}
	else if(result_token[parse_point].type == 98)	//IntNo Expr_
	{
		TreeNode * t = newExpNode(NumK);
		t->attr.val = atoi(result_token[parse_point].name);
		parse_point++;
		TreeNode * p = Expr_();
		if (p != NULL)
		{
			p->child[0] = t;	//p->child[1]��Expr_�н����趨
			return p;
		}
		else return t;
	}
	else if (result_token[parse_point].type == 99)	//RealNo Expr_
	{
		TreeNode * t = newExpNode(NumK);
		t->attr.val = atoi(result_token[parse_point].name);
		parse_point++;
		TreeNode * p = Expr_();
		if (p != NULL)
		{
			p->child[0] = t;	//p->child[1]��Expr_�н����趨
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
		TreeNode * p = Expr();
		Expr_();	//********************�о�ÿ�ζ��ǿգ��ݶ�
		t->child[1] = p;
		return t;
	}
	else if (match("-"))	//'-' Expr Expr_
	{
		TreeNode * t = newExpNode(OpK);
		strcpy(t->attr.name, "-");
		TreeNode * p = Expr();
		Expr_();	//********************�о�ÿ�ζ��ǿգ��ݶ�
		t->child[1] = p;
		return t;
	}
	else if (match("*"))	//'*' Expr Expr_
	{
		TreeNode * t = newExpNode(OpK);
		strcpy(t->attr.name, "*");
		TreeNode * p = Expr();
		Expr_();	//********************�о�ÿ�ζ��ǿգ��ݶ�
		t->child[1] = p;
		return t;
	}
	else if (match("/"))	//'/' Expr Expr_
	{
		TreeNode * t = newExpNode(OpK);
		strcpy(t->attr.name, "/");
		TreeNode * p = Expr();
		Expr_();	//********************�о�ÿ�ζ��ǿգ��ݶ�
		t->child[1] = p;
		return t;
	}
	else if (match(">"))	//'>' Expr Expr_
	{
		TreeNode * t = newExpNode(OpK);
		strcpy(t->attr.name, ">");
		TreeNode * p = Expr();
		Expr_();	//********************�о�ÿ�ζ��ǿգ��ݶ�
		t->child[1] = p;
		return t;
	}
	else if (match("<"))	//'<' Expr Expr_
	{
		TreeNode * t = newExpNode(OpK);
		strcpy(t->attr.name, "<");
		TreeNode * p = Expr();
		Expr_();	//********************�о�ÿ�ζ��ǿգ��ݶ�
		t->child[1] = p;
		return t;
	}
	else if (match(">="))	//'>=' Expr Expr_
	{
		TreeNode * t = newExpNode(OpK);
		strcpy(t->attr.name, ">=");
		TreeNode * p = Expr();
		Expr_();	//********************�о�ÿ�ζ��ǿգ��ݶ�
		t->child[1] = p;
		return t;
	}
	else if (match("<="))	//'<=' Expr Expr_
	{
		TreeNode * t = newExpNode(OpK);
		strcpy(t->attr.name, "<=");
		TreeNode * p = Expr();
		Expr_();	//********************�о�ÿ�ζ��ǿգ��ݶ�
		t->child[1] = p;
		return t;
	}
	else if (match("<>"))	//'<>' Expr Expr_
	{
		TreeNode * t = newExpNode(OpK);
		strcpy(t->attr.name, "<>");
		TreeNode * p = Expr();
		Expr_();	//********************�о�ÿ�ζ��ǿգ��ݶ�
		t->child[1] = p;
		return t;
	}
	else if (match("="))	//'=' Expr Expr_
	{
		TreeNode * t = newExpNode(OpK);
		strcpy(t->attr.name, "=");
		TreeNode * p = Expr();
		Expr_();	//********************�о�ÿ�ζ��ǿգ��ݶ�
		t->child[1] = p;
		return t;
	}
	else if (match("and"))	//'and' Expr Expr_
	{
		TreeNode * t = newExpNode(OpK);
		strcpy(t->attr.name, "and");
		TreeNode * p = Expr();
		Expr_();	//********************�о�ÿ�ζ��ǿգ��ݶ�
		t->child[1] = p;
		return t;
	}
	else if (match("or"))	//'or' Expr Expr_
	{
	TreeNode * t = newExpNode(OpK);
	strcpy(t->attr.name, "or");
	TreeNode * p = Expr();
	Expr_();	//********************�о�ÿ�ζ��ǿգ��ݶ�
	t->child[1] = p;
	return t;
	}
}
TreeNode * Type()
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
	return NULL;
}
TreeNode * Statement()
{
	if (result_token[parse_point].type == 100)	//AssignState
	{
		AssignState();
	}
	else if (match("if"))	//IBT Statement Statement��
	{
		parse_point--;	//��IBT���������ж�"if"���Ͼ�����ֻ�Ǹ����ս��
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
	return NULL;
}
TreeNode * Statement_()
{
	if (match("else"))			//"else" Statement
	{
		Statement();
	}
	return NULL;
}
 TreeNode * IBT()
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
	return NULL;
}
TreeNode * WBD()
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
	return NULL;
}
TreeNode * CompState()
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
	return NULL;
}
int find_Iden()
{
	if (result_token[parse_point].array_element == 1)	//����Ԫ�ز����﷨�����м�⣬�ڴʷ��������Ѿ�������
	{
		return 1;
	}
	for (int i = 0;i < free_Iden_state_list;i++)
	{
		if (strcmp(result_token[parse_point].name, Iden_state_list[i]) == 0)
		{
			//printf("this var is stated\n");		//ʹ�����Ѿ������ı������Բ����
			return 1;
		}
	}
	return 0;
	
}

TreeNode * AssignState()
{
	if (result_token[parse_point].type == 100)	//Iden ':=' Expr	
	{
		if (find_Iden() == 0)
		{
			printf("Error: this var : %s isn't stated, row num: %d\n", result_token[parse_point].name, result_token[parse_point].row_num);	//ʹ��δ��������������
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
	return NULL;
}
TreeNode * StateList()
{
	Statement();	//Statement StateList_
	StateList_();
	return NULL;
}
TreeNode * StateList_()
{
	if (match(";"))	//';' Statement StateList_
	{
		Statement();
		StateList_();
	}
	return NULL;
}
TreeNode * VarList()
{
	if (result_token[parse_point].type == 100)	//Iden VarList_
	{
		if (find_Iden() == 1)	//�ظ������⣬����Error����
		{
			printf("Error: repeat state var: %s , row num: %d\n", result_token[parse_point].name, result_token[parse_point].row_num);
			exit(0);
		}
		strcpy(Iden_state_list[free_Iden_state_list++], result_token[parse_point].name);	//��ӵ�������������
		parse_point++;
		VarList_();
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
			if (find_Iden() == 1)	//�ظ������⣬����Error����
			{
				printf("Error: repeat state var: %s , row num: %d\n", result_token[parse_point].name, result_token[parse_point].row_num);
				exit(0);
			}
			strcpy(Iden_state_list[free_Iden_state_list++], result_token[parse_point].name);	//��ӵ�������������
			parse_point++;
			VarList_();
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
	VarList();			//VarList ':' Type
	if (match(":"))
	{
		Type();
	}
	else
	{
		wrong_sentence();
	}
	return NULL;
}
TreeNode * VarDefList()
{
	VarDefState();		//VarDefState VarDefList_
	VarDefList_();
	return NULL;
}
TreeNode * VarDefList_()
{
	if (match(";"))		//';' VarDefState VarDefList'|
	{
		VarDefState();
		VarDefList_();
	}
	return NULL;
}
TreeNode * VarDef()
{
	if (match("var"))		//"var" VarDefList 
	{
		VarDefList();
	}
	else
	{
		wrong_sentence();
	}
	return NULL;
}
TreeNode * SubProg()
{
	VarDef();		// VarDef CompState
	CompState();
	return NULL;
}
TreeNode * ProgDef()		// "program" Iden ';' SubProg '.'
{
	if (match("program") && result_token[parse_point++].type == 100 && match(";"))
	{
		strcpy(Iden_state_list[free_Iden_state_list++], result_token[parse_point - 2].name);	//��ӵ�������������
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
	return NULL;
}


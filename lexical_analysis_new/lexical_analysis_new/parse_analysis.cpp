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
int quaternary_free = 0;
struct quaternary quaternary[100] = { 0 };
int tmp = 0;
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
			generate_quaternary(p->attr.name, Iden_state_list[p->child[0]->PLACE], Iden_state_list[p->child[1]->PLACE], Iden_state_list[p->PLACE]);
			return p;
									//p->child[1]��Expr_�н����趨
		}							//�������һ�����ȼ����⣬��(5+6)+7�����ӣ���һ��+��Expr�ķ���ֵ���ڶ���+��
		else						//Expr_�ķ���ֵ���������е�Ӧ����������ԵͲ�������
		{
			//generate_quaternary(t->attr.name, Iden_state_list[t->child[0]->PLACE], Iden_state_list[t->child[1]->PLACE], Iden_state_list[t->PLACE]);
			return t;
		}
								

	}
	else if (result_token[parse_point].type == 100)	//Iden Expr_
	{
		int PLACE = find_Iden();
		if (find_Iden() == 0)	//�����Ƿ��������
		{
			printf("Error: this var : %s isn't stated, row num: %d\n", result_token[parse_point].name, result_token[parse_point].row_num);	//ʹ��δ��������������
			exit(0);
		}
		TreeNode * t = newExpNode(IdK);
		strcpy(t->attr.name, result_token[parse_point].name);
		t->PLACE = PLACE;	//ָ����ű��Ӧ���ָ��
		parse_point++;
		TreeNode * p = Expr_();
		if (p != NULL)
		{
			p->child[0] = t;	//p->child[1]��Expr_�н����趨
			generate_quaternary(p->attr.name, Iden_state_list[p->child[0]->PLACE], Iden_state_list[p->child[1]->PLACE], Iden_state_list[p->PLACE]);
			return p;
		}
		else return t;
	}
	else if(result_token[parse_point].type == 98)	//IntNo Expr_
	{
		TreeNode * t = newExpNode(intNumK);
		t->attr.val = atoi(result_token[parse_point].name);
		t->PLACE = free_Iden_state_list;	//רΪ�����趨,��ʱ������ָ��
		strcpy(Iden_state_list[free_Iden_state_list++], result_token[parse_point].name);
		parse_point++;
		TreeNode * p = Expr_();
		if (p != NULL)
		{
			p->child[0] = t;	//p->child[1]��Expr_�н����趨
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
			p->child[0] = t;	//p->child[1]��Expr_�н����趨
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
		Expr_();	//********************�о�ÿ�ζ��ǿգ��ݶ�
		t->child[1] = p;
		return t;
	}
	else if (match("-"))	//'-' Expr Expr_
	{
		TreeNode * t = newExpNode(OpK);
		strcpy(t->attr.name, "-");
		t->PLACE = generate_tmp();
		TreeNode * p = Expr();
		Expr_();	//********************�о�ÿ�ζ��ǿգ��ݶ�
		t->child[1] = p;
		return t;
	}
	else if (match("*"))	//'*' Expr Expr_
	{
		TreeNode * t = newExpNode(OpK);
		strcpy(t->attr.name, "*");
		t->PLACE = generate_tmp();
		TreeNode * p = Expr();
		Expr_();	//********************�о�ÿ�ζ��ǿգ��ݶ�
		t->child[1] = p;
		return t;
	}
	else if (match("/"))	//'/' Expr Expr_
	{
		TreeNode * t = newExpNode(OpK);
		strcpy(t->attr.name, "/");
		t->PLACE = generate_tmp();
		TreeNode * p = Expr();
		Expr_();	//********************�о�ÿ�ζ��ǿգ��ݶ�
		t->child[1] = p;
		return t;
	}
	else if (match(">"))	//'>' Expr Expr_
	{
		TreeNode * t = newExpNode(OpK);
		strcpy(t->attr.name, ">");
		t->PLACE = generate_tmp();
		TreeNode * p = Expr();
		Expr_();	//********************�о�ÿ�ζ��ǿգ��ݶ�
		t->child[1] = p;
		return t;
	}
	else if (match("<"))	//'<' Expr Expr_
	{
		TreeNode * t = newExpNode(OpK);
		strcpy(t->attr.name, "<");
		t->PLACE = generate_tmp();
		TreeNode * p = Expr();
		Expr_();	//********************�о�ÿ�ζ��ǿգ��ݶ�
		t->child[1] = p;
		return t;
	}
	else if (match(">="))	//'>=' Expr Expr_
	{
		TreeNode * t = newExpNode(OpK);
		strcpy(t->attr.name, ">=");
		t->PLACE = generate_tmp();
		TreeNode * p = Expr();
		Expr_();	//********************�о�ÿ�ζ��ǿգ��ݶ�
		t->child[1] = p;
		return t;
	}
	else if (match("<="))	//'<=' Expr Expr_
	{
		TreeNode * t = newExpNode(OpK);
		strcpy(t->attr.name, "<=");
		t->PLACE = generate_tmp();
		TreeNode * p = Expr();
		Expr_();	//********************�о�ÿ�ζ��ǿգ��ݶ�
		t->child[1] = p;
		return t;
	}
	else if (match("<>"))	//'<>' Expr Expr_
	{
		TreeNode * t = newExpNode(OpK);
		strcpy(t->attr.name, "<>");
		t->PLACE = generate_tmp();
		TreeNode * p = Expr();
		Expr_();	//********************�о�ÿ�ζ��ǿգ��ݶ�
		t->child[1] = p;
		return t;
	}
	else if (match("="))	//'=' Expr Expr_
	{
		TreeNode * t = newExpNode(OpK);
		strcpy(t->attr.name, "=");
		t->PLACE = generate_tmp();
		TreeNode * p = Expr();
		Expr_();	//********************�о�ÿ�ζ��ǿգ��ݶ�
		t->child[1] = p;
		return t;
	}
	else if (match("and"))	//'and' Expr Expr_
	{
		TreeNode * t = newExpNode(OpK);
		strcpy(t->attr.name, "and");
		t->PLACE = generate_tmp();
		TreeNode * p = Expr();
		Expr_();	//********************�о�ÿ�ζ��ǿգ��ݶ�
		t->child[1] = p;
		return t;
	}
	else if (match("or"))	//'or' Expr Expr_
	{
	TreeNode * t = newExpNode(OpK);
	strcpy(t->attr.name, "or");
	t->PLACE = generate_tmp();
	TreeNode * p = Expr();
	Expr_();	//********************�о�ÿ�ζ��ǿգ��ݶ�
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
	else if (match("if"))	//IBT Statement Statement��
	{
		s = newStmtNode(IfK);
		parse_point--;	//��IBT���������ж�"if"���Ͼ�����ֻ�Ǹ����ս��
		t = IBT();
		q = Statement();
		s->child[0] = t;	//test����
		s->child[1] = q;	//then����
		p = Statement_();
		if (p != NULL)
		{
			s->child[2] = p;	//else����
		}
		return s;
	}
	else if (match("while"))	//WBD Statement
	{
		parse_point--;
		s = newStmtNode(WhileK);
		t = WBD();			//test����
		q = Statement();	//do����
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
	if (result_token[parse_point].array_element == 1)	//����Ԫ�ز����﷨�����м�⣬�ڴʷ��������Ѿ�������
	{
		return 1;
	}
	for (int i = 0;i < free_Iden_state_list;i++)
	{
		if (strcmp(result_token[parse_point].name, Iden_state_list[i]) == 0)
		{
			//printf("this var is stated\n");		//ʹ�����Ѿ������ı������Բ����
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
			printf("Error: this var : %s isn't stated, row num: %d\n", result_token[parse_point].name, result_token[parse_point].row_num);	//ʹ��δ��������������
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
		s->sibling = t;	//���й�ϵ��sibling
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
			s->sibling = t;	//���й�ϵ��sibling
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
		/*if (find_Iden() == 1)	//�ظ������⣬����Error����
		{
			printf("Error: repeat state var: %s , row num: %d\n", result_token[parse_point].name, result_token[parse_point].row_num);
			exit(0);
		}*/
		TreeNode *s = newExpNode(IdK);
		strcpy(s->attr.name, result_token[parse_point].name);
		strcpy(Iden_state_list[free_Iden_state_list++], result_token[parse_point].name);	//��ӵ�������������
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
			/*if (find_Iden() == 1)	//�ظ������⣬����Error����
			{
				printf("Error: repeat state var: %s , row num: %d\n", result_token[parse_point].name, result_token[parse_point].row_num);
				exit(0);
			}*/
			TreeNode *s = newExpNode(IdK);
			strcpy(s->attr.name, result_token[parse_point].name);
			strcpy(Iden_state_list[free_Iden_state_list++], result_token[parse_point].name);	//��ӵ�������������
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
		strcpy(Iden_state_list[free_Iden_state_list++], result_token[parse_point - 2].name);	//��ӵ�������������
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

/**************************������Ԫʽ��غ���*****************/
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
int generate_tmp()	//����һ����ʱ����
{
	char tmp_name[10] = "t";
	char num[5] = { 0 };
	itoa(tmp,num,10);
	strcat(tmp_name,num);
	strcpy(Iden_state_list[free_Iden_state_list++], tmp_name);
	tmp++;
	return free_Iden_state_list - 1;
}

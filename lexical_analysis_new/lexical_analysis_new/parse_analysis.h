#pragma once
#include "global.h"
/********************************错误处理************************************/
void wrong_sentence();
/*******************************递归下降文法函数表声明******************************/
 TreeNode * ProgDef();			//ProgDef:      "program" Iden ';' SubProg '.'
 TreeNode * SubProg();			//SubProg:      VarDef CompState
 TreeNode * VarDef();			//VarDef:	    "var" VarDefList
 TreeNode * VarDefList();		//VarDefList:	VarDefState VarDefList_
 TreeNode * VarDefList_();		//VarDefList_:  ';'VarDefState VarDefList_ |
 TreeNode * VarDefState();		//VarDefState:  VarList ':' Type
 TreeNode * Type();			//Type:         "integer" | "reald"
 TreeNode * VarList();			//VarList:		Iden VarList'
 TreeNode * VarList_();		//VarList_:		',' Iden VarList_|
 TreeNode * StateList();		//StateList:    S_L Statement  |  Statement
 TreeNode * StateList_();		//StateList‘:	   ';' Statement StateList‘ |
 TreeNode * Statement();		//Statement:    AssignState  | IBT Statement| WBD Statement | CompState |
 TreeNode * Statement_();		//Statement_:	"else" Statement |
 TreeNode * CompState();		//CompState:	"begin" StateList "end"
 TreeNode * AssignState();		//AssignState:	Iden ':=' Expr
 TreeNode * IBT();				//IBT:			"if" Expr "then"
 TreeNode * WBD();				//WBD:			"while" Expr "do"
 TreeNode * Expr();			//Expr:			"(" Expr ")" Expr_| "not" Expr Expr_ | Iden Expr_ | IntNo Expr_	| RealNo Expr_ 				
 TreeNode * Expr_();			//Expr_:		"+" Expr Expr_ | "-" Expr Expr_ | "*" Expr Expr_ |"/" Expr Expr_ |
						//				">" Expr Expr_ | "<" Expr Expr_ | ">=" Expr Expr_ | "<=" Expr Expr_|
						//				"=" Expr Expr_ | "<>" Expr Expr_ | "and" Expr Expr_ | "or" Expr Expr_ |
int find_Iden();
extern char Iden_state_list[200][50];	//变量声明表
extern int free_Iden_state_list;
struct quaternary
{
	char op[50];
	char arg1[50];
	char arg2[50];
	char result[50];
};
extern int quaternary_free;
void generate_quaternary(char[], char[], char[], char[]);
int generate_tmp();
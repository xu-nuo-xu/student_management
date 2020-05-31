#pragma once
/********************************错误处理************************************/
void wrong_sentence();
/*******************************递归下降文法函数表声明******************************/
void ProgDef();			//ProgDef:      "program" Iden ';' SubProg '.'
void SubProg();			//SubProg:      VarDef CompState
void VarDef();			//VarDef:	    "var" VarDefList
void VarDefList();		//VarDefList:	VarDefState VarDefList_
void VarDefList_();		//VarDefList_:  ';'VarDefState VarDefList_ |
void VarDefState();		//VarDefState:  VarList ':' Type
void Type();			//Type:         "integer" | "reald"
void VarList();			//VarList:		Iden VarList'
void VarList_();		//VarList_:		',' Iden VarList_|
void StateList();		//StateList:    S_L Statement  |  Statement
void StateList_();		//StateList‘:	   ';' Statement StateList‘ |
void Statement();		//Statement:    AssignState  | IBT Statement| WBD Statement | CompState |
void Statement_();		//Statement_:	"else" Statement |
void CompState();		//CompState:	"begin" StateList "end"
void AssignState();		//AssignState:	Iden ':=' Expr
void IBT();				//IBT:			"if" Expr "then"
void WBD();				//WBD:			"while" Expr "do"
void Expr();			//Expr:			"(" Expr ")" Expr_| "not" Expr Expr_ | Iden Expr_ | IntNo Expr_	| RealNo Expr_ 				
void Expr_();			//Expr_:		"+" Expr Expr_ | "-" Expr Expr_ | "*" Expr Expr_ |"/" Expr Expr_ |
						//				">" Expr Expr_ | "<" Expr Expr_ | ">=" Expr Expr_ | "<=" Expr Expr_|
						//				"=" Expr Expr_ | "<>" Expr Expr_ | "and" Expr Expr_ | "or" Expr Expr_ |
			


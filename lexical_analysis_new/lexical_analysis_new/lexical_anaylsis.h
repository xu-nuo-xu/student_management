#pragma once
struct token {
	int type;	//�ֱ���
	char name[10];	//����
	int row_num;
};
extern int parse_point;		//ָ��ǰʶ���result_token
#pragma once
struct token {
	int type;	//�ֱ���
	char name[10];	//����
	int row_num;
	int array_element;	//�Ƿ�Ϊ����Ԫ��
};
extern int parse_point;		//ָ��ǰʶ���result_token
extern int array_num;		//רΪarray��������
extern int array_element;	//�Ƿ�Ϊ����Ԫ��
struct array_info			//����������Ϣ��
{		
	char array_name[50];
	int array_num;
};
extern int free_array_info;	//����������Ϣ��������
extern int lineno;
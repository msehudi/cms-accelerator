
export class ModuleData {
    modules!: Module[];
    questionTypes!: QuestionType[];
}

export class Module {
    id!: string;
    name!: string;
    webPages!: WebPage[];
}

export class WebPage {
    id!: string;
    name!: string;
    footer!: string;
    header!: string;
    showSaveButton: boolean = false;
    showSubmitButton: boolean = false;
    showBackButton: boolean = false;
    showNextButton: boolean = false;
    questions!: Question[];
}

export class Question {
    id!: string;
    value!: string;
    label!: string;
    name?: string;
    order?: number;
    type!: string;
    controlType?: string;
    questionTypeId!: string;
}

export class QuestionType {
    id!: string;
    name!: string;
    defaultValue?: string;
    order?: number;
    type!: string;
    controlType?: string;
    options: { label: string, value: string }[] = [];
}
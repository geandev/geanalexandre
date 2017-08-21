import { SkillLevel } from "./SkillLevel";

export class Skill {
    label: string;
    level: SkillLevel;

    public static getLevelName(level: SkillLevel): string {
        return SkillLevel[level].toLocaleLowerCase();
    }
}
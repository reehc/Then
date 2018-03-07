class HolaCheer::Translator

  def initialize(language)
    @language = language
  end

  def sayHi
    case @language
    when "English"
      "Hello Gem!"
    when "Chinese"
      "嗯。。。"
    else
      "Cheer!"
    end
  end

end

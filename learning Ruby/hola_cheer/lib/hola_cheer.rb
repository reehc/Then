class HolaCheer
  def self.hi(language = "")
    translator = Translator.new(language)
    translator.sayHi
  end
end

require 'hola_cheer/translator'

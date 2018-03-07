require 'minitest/autorun'
require 'hola_cheer'

class HolaTest < Minitest::Test
  def test_english_hello
    assert_equal "Hello Gem!",
      HolaCheer.hi("English")
  end

  def test_any_hello
    assert_equal "嗯。。。",
      HolaCheer.hi("Chinese")
  end

  def test_spanish_hello
    assert_equal "Cheer!",
      HolaCheer.hi("")
  end
end


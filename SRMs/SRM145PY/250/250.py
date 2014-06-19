class ImageDithering:
	def count(self, dithered, screen):
		result = 0
		for dit in dithered:
			for point in screen:
				if point == dit:
					result += 1
		return result